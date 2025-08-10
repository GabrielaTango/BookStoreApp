using BL.wsfev1;
using Models;
using Models.FacturaElectronica;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BL
{
    public class FacturaService
    {
        const string DEFAULT_SERVICIO = "wsfe";
        const string DEFAULT_CERTSIGNER = @"d:\repos\afip\cert.pfx";
        const string DEFAULT_URLWSAAWSDL = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms";
        const string DEFAULT_URLFEV1WSDL = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx";
        const string _clave = "privada_ejemplo";
        private static UInt32 _globalUniqueID = 0;

        public string XmlStrLoginTicketRequestTemplate = "<loginTicketRequest><header><source>SERIALNUMBER=CUIT 20290077207, CN=prueba2025</source><destination>CN=wsaahomo, O=AFIP, C=AR, SERIALNUMBER=CUIT 33693450239</destination><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>";
        SecureString strPasswordSecureString = new SecureString();
        
        string _taFile = "ta.xml";

        private FECredenciales _credenciales { get; set; }
        public FacturaService()
        {
            CargarCredenciales();
        }

        private void CargarCredenciales()
        {
            XmlDocument taDoc = new XmlDocument();
            taDoc.Load(_taFile);

            string token = taDoc.SelectSingleNode("//token")?.InnerText;
            string sign = taDoc.SelectSingleNode("//sign")?.InnerText;
            string cuit = taDoc.SelectSingleNode("//destination")?.InnerText;
            string expirationText = taDoc.SelectSingleNode("//expirationTime")?.InnerText;
            DateTime expiration = new DateTime();

            DateTime.TryParse(expirationText, out expiration);

            _credenciales = new FECredenciales()
            {
                Token = token,
                Sign = sign,
                Cuit = cuit,
                ExpirationTime = expiration
            };
        }

        public void GetTA()
        {

            const string DEFAULT_SERVICIO = "wsfe";
            const string DEFAULT_CERTSIGNER = @"d:\repos\afip\cert.pfx";
            const string DEFAULT_PROXY = null;
            const string DEFAULT_PROXY_USER = null;
            const string DEFAULT_PROXY_PASSWORD = null;
            const bool DEFAULT_VERBOSE = true;

            const string ID_FNC = "[Main]";

            string strUrlWsaaWsdl = DEFAULT_URLWSAAWSDL;
            string strIdServicioNegocio = DEFAULT_SERVICIO;
            string strRutaCertSigner = DEFAULT_CERTSIGNER;
            SecureString strPasswordSecureString = new SecureString();
            string strProxy = DEFAULT_PROXY;
            string strProxyUser = DEFAULT_PROXY_USER;
            string strProxyPassword = DEFAULT_PROXY_PASSWORD;
            bool blnVerboseMode = DEFAULT_VERBOSE;

            LoginTicket objTicketRespuesta = null;
            string strTicketRespuesta = null;

            try
            {
                if (blnVerboseMode)
                {
                    Console.WriteLine(ID_FNC + "***Servicio a acceder: {0}", strIdServicioNegocio);
                    Console.WriteLine(ID_FNC + "***URL del WSAA: {0}", strUrlWsaaWsdl);
                    Console.WriteLine(ID_FNC + "***Ruta del certificado: {0}", strRutaCertSigner);
                    Console.WriteLine(ID_FNC + "***Modo verbose: {0}", blnVerboseMode);
                }

                foreach (char c in _clave) strPasswordSecureString.AppendChar(c);
                strPasswordSecureString.MakeReadOnly();

                objTicketRespuesta = new LoginTicket();
                if (blnVerboseMode) Console.WriteLine(ID_FNC + "***Accediendo a {0}", strUrlWsaaWsdl);
                strTicketRespuesta = objTicketRespuesta.ObtenerLoginTicketResponse(
                    strIdServicioNegocio, strUrlWsaaWsdl
                    , strRutaCertSigner, strPasswordSecureString
                    , strProxy, strProxyUser, strProxyPassword
                    , blnVerboseMode);
            }
            catch (Exception excepcionAlObtenerTicket)
            {
                Console.WriteLine(ID_FNC + "***EXCEPCION AL OBTENER TICKET: " + excepcionAlObtenerTicket.Message);
            }


        }


        public void ObtenerTA()
        {

            if (_credenciales.ExpirationTime > DateTime.Now)
                return;

            var cmsFirmadoBase64 = GetCmsFirmadoBase64();

            string soapRequest = $@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:wsaa=""http://wsaa.view.sua.dvadac.desein.afip.gov"">
<soapenv:Header/>
<soapenv:Body>
    <wsaa:loginCms>
        <wsaa:in0>{System.Security.SecurityElement.Escape(cmsFirmadoBase64)}</wsaa:in0>
    </wsaa:loginCms>
</soapenv:Body>
</soapenv:Envelope>
";

            var response = AfipSoapClient.SendSoapRequestAsync(soapRequest, SOAPAction.Ninguna, DEFAULT_URLWSAAWSDL);

            if (response.IsSuccessStatusCode)
            { 
                string soapResponse = response.Content.ReadAsStringAsync().Result;

                // Extraer el TA (es un XML en string base64)
                var doc = new XmlDocument();
                doc.LoadXml(soapResponse);
                var taNode = doc.GetElementsByTagName("loginCmsReturn")[0];

                if (taNode != null && !string.IsNullOrEmpty(taNode.InnerText))
                    File.WriteAllText("ta.xml", taNode.InnerText);
                if (taNode?.InnerText == null)
                    throw new Exception("No se pudo obtener el TA");

                CargarCredenciales();
            }
        }

        private string GetCmsFirmadoBase64()
        {
            XmlDocument XmlLoginTicketRequest = new XmlDocument();
            XmlLoginTicketRequest.LoadXml(XmlStrLoginTicketRequestTemplate);
            XmlNode xmlNodoUniqueId = default(XmlNode);
            XmlNode xmlNodoGenerationTime = default(XmlNode);
            XmlNode xmlNodoExpirationTime = default(XmlNode);
            XmlNode xmlNodoService = default(XmlNode);

            _globalUniqueID += 1;
            xmlNodoUniqueId = XmlLoginTicketRequest.SelectSingleNode("//uniqueId");
            xmlNodoGenerationTime = XmlLoginTicketRequest.SelectSingleNode("//generationTime");
            xmlNodoExpirationTime = XmlLoginTicketRequest.SelectSingleNode("//expirationTime");
            xmlNodoService = XmlLoginTicketRequest.SelectSingleNode("//service");
            xmlNodoGenerationTime.InnerText = DateTime.Now.AddMinutes(-10).ToString("s");
            xmlNodoExpirationTime.InnerText = DateTime.Now.AddMinutes(+10).ToString("s");
            xmlNodoUniqueId.InnerText = Convert.ToString(_globalUniqueID);
            xmlNodoService.InnerText = DEFAULT_SERVICIO;

            foreach (char c in _clave) strPasswordSecureString.AppendChar(c);
            strPasswordSecureString.MakeReadOnly();

            X509Certificate2 certFirmante = CertificadosX509Lib.ObtieneCertificadoDesdeArchivo(DEFAULT_CERTSIGNER, strPasswordSecureString);

            // Convierto el Login Ticket Request a bytes, firmo el msg y lo convierto a Base64
            Encoding EncodedMsg = Encoding.UTF8;
            byte[] msgBytes = EncodedMsg.GetBytes(XmlLoginTicketRequest.OuterXml);
            byte[] encodedSignedCms = CertificadosX509Lib.FirmaBytesMensaje(msgBytes, certFirmante);
            var cmsFirmadoBase64 = Convert.ToBase64String(encodedSignedCms);
            return cmsFirmadoBase64;
        }

        private int _proximo;

        public CAEVTO Facturar(FECAEDetRequest c)
        {
            // Cargar el token desde archivo TA.xml

            string wsfev1Url = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx";

            var envelope = new Envelope
            {
                Header = null,
                Body = new Body
                {
                    FECAESolicitar = new FECAESolicitar
                    {
                        Auth = new Auth
                        {
                            Token = _credenciales.Token,
                            Sign = _credenciales.Sign,
                            Cuit = 20290077207
                        },
                        FeCAEReq = new FeCAEReq
                        {
                            FeCabReq = new FeCabReq
                            {
                                CantReg = 1,
                                PtoVta = 13,
                                CbteTipo = 11
                            },
                            FeDetReq = new FeDetReq
                            {
                                FECAEDetRequest = new List<FECAEDetRequest>
                                { 
                                    c
                                }
                            }
                        }
                    }
                }
            };
            var envelopeStr = "";

            XmlSerializer xmlSerializer = new XmlSerializer(envelope.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, envelope);
                envelopeStr = textWriter.ToString();
            }

            var response = AfipSoapClient.SendSoapRequestAsync(envelopeStr, SOAPAction.FECAESolicitar, DEFAULT_URLFEV1WSDL);
            var resultXml = response.Content.ReadAsStringAsync().Result;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(resultXml);

            // Namespace manager
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.AddNamespace("afip", "http://ar.gov.afip.dif.FEV1/");

            // Obtener nodos
            var caeNode = doc.SelectSingleNode("//afip:CAE", ns);
            var caeFchVtoNode = doc.SelectSingleNode("//afip:CAEFchVto", ns);
            XmlNodeList errores = doc.SelectNodes("//afip:Errors/afip:Err", ns);

            foreach (XmlNode err in errores)
            {
                string code = err.SelectSingleNode("afip:Code", ns)?.InnerText;
                string msg = err.SelectSingleNode("afip:Msg", ns)?.InnerText;
            }

            CAEVTO caeYVto = new CAEVTO();

            if (caeNode != null && caeFchVtoNode != null)
            {
                string cae = caeNode.InnerText;
                DateTime caeVto = DateTime.ParseExact(caeFchVtoNode.InnerText, "yyyyMMdd", null);
                caeYVto.CAE = cae;
                caeYVto.VTO = caeVto;
            }
            return caeYVto;
        }

        public bool UltimoComp()
        {
            var cbteNro = -1;

            var ptoVenta = "13";
            var tipoComp = "11";
            string soapEnvelope =
            "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:ar=\"http://ar.gov.afip.dif.FEV1/\">"
    + @$"<soapenv:Header/>
   <soapenv:Body>
      <ar:FECompUltimoAutorizado>
        <ar:Auth>
                <ar:Token>{_credenciales.Token}</ar:Token>
                <ar:Sign>{_credenciales.Sign}</ar:Sign>
                <ar:Cuit>20290077207</ar:Cuit>
         </ar:Auth>
         <ar:PtoVta>{ptoVenta}</ar:PtoVta>
         <ar:CbteTipo>{tipoComp}</ar:CbteTipo>
      </ar:FECompUltimoAutorizado>
   </soapenv:Body>
</soapenv:Envelope>";

            var response = AfipSoapClient.SendSoapRequestAsync(soapEnvelope, SOAPAction.FECompUltimoAutorizado, DEFAULT_URLFEV1WSDL);

            if (response.IsSuccessStatusCode)
            {
                var resultXml = response.Content.ReadAsStringAsync().Result;

                XDocument doc = XDocument.Parse(resultXml);

                // Definir los namespaces
                XNamespace soap = "http://schemas.xmlsoap.org/soap/envelope/";
                XNamespace fev1 = "http://ar.gov.afip.dif.FEV1/";

                // Navegar y obtener el valor
                var comp = doc
                    .Descendants(fev1 + "CbteNro")
                    .FirstOrDefault()?.Value;


                int.TryParse(comp, out cbteNro);

                _proximo = cbteNro + 1;
            }
            return true;
        }

        public static string SerializeToXmlFragment<T>(T obj)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using var sw = new StringWriter();
            xmlSerializer.Serialize(sw, obj, ns);
            var xml = sw.ToString();

            // Elimina declaración <?xml ... ?> si está presente
            int index = xml.IndexOf("?>");
            return index > 0 ? xml.Substring(index + 2) : xml;
        }

        public int GetProximo() => _proximo;
        
    }

    public static class SOAPAction
    {
        public const string FECompUltimoAutorizado = "http://ar.gov.afip.dif.FEV1/FECompUltimoAutorizado";
        public const string FECAESolicitar = "http://ar.gov.afip.dif.FEV1/FECAESolicitar";
        public const string Ninguna = "";
    }

}
