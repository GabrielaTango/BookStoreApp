namespace Models.FacturaElectronica
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public object Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
    }

    public class Body
    {
        [XmlElement(ElementName = "FECAESolicitar", Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public FECAESolicitar FECAESolicitar { get; set; }
    }

    public class FECAESolicitar
    {
        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public Auth Auth { get; set; }

        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public FeCAEReq FeCAEReq { get; set; }
    }

    public class Auth
    {
        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public string Token { get; set; }

        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public string Sign { get; set; }

        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public long Cuit { get; set; }
    }

    public class FeCAEReq
    {
        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public FeCabReq FeCabReq { get; set; }

        [XmlElement(Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public FeDetReq FeDetReq { get; set; }
    }

    public class FeCabReq
    {
        public int CantReg { get; set; }
        public int PtoVta { get; set; }
        public int CbteTipo { get; set; }
    }

    public class FeDetReq
    {
        [XmlElement("FECAEDetRequest", Namespace = "http://ar.gov.afip.dif.FEV1/")]
        public List<FECAEDetRequest> FECAEDetRequest { get; set; }
    }

    public class FECAEDetRequest
    {
        public int Concepto { get; set; }
        public int DocTipo { get; set; }
        public long DocNro { get; set; }
        public int CbteDesde { get; set; }
        public int CbteHasta { get; set; }
        public string CbteFch { get; set; }
        public decimal ImpTotal { get; set; }
        public decimal ImpTotConc { get; set; }
        public decimal ImpNeto { get; set; }
        public decimal ImpOpEx { get; set; }
        public decimal ImpTrib { get; set; }
        public decimal ImpIVA { get; set; }
        public string FchServDesde { get; set; }
        public string FchServHasta { get; set; }
        public string FchVtoPago { get; set; }
        public string MonId { get; set; }
        public decimal MonCotiz { get; set; }

        public int CondicionIVAReceptorId { get; set; }

        public List<CbteAsoc> CbtesAsoc { get; set; }
        public List<Tributo> Tributos { get; set; }
        public List<AlicIva> Iva { get; set; }
        public List<Opcional> Opcionales { get; set; }
        public List<Comprador> Compradores { get; set; }
        public PeriodoAsoc PeriodoAsoc { get; set; }
        public List<Actividad> Actividades { get; set; }
    }

    public class CbteAsoc
    {
        public int Tipo { get; set; }
        public int PtoVta { get; set; }
        public int Nro { get; set; }
        public long? Cuit { get; set; }
        public string CbteFch { get; set; }
    }

    public class Tributo
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public decimal BaseImp { get; set; }
        public decimal Alic { get; set; }
        public decimal Importe { get; set; }
    }

    public class AlicIva
    {
        public int Id { get; set; }
        public decimal BaseImp { get; set; }
        public decimal Importe { get; set; }
    }

    public class Opcional
    {
        public string Id { get; set; }
        public string Valor { get; set; }
    }

    public class Comprador
    {
        public int DocTipo { get; set; }
        public long DocNro { get; set; }
        public decimal Porcentaje { get; set; }
    }

    public class PeriodoAsoc
    {
        public string FchDesde { get; set; }
        public string FchHasta { get; set; }
    }

    public class Actividad
    {
        public string Id { get; set; }
    }

}
