 public void CrearDocumentoFactura()
        {                                                               
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaracion = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlElement FacturaElectronica = xmlDoc.CreateElement("ds", "FacturaElectronica", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica");
           
            XmlElement clave = xmlDoc.CreateElement("ds", "clave", "");
            clave.InnerText = "123";
            XmlElement consecutivo = xmlDoc.CreateElement("ds", "consecutivo", "");
            consecutivo.InnerText = "dsdgdfg"; 
            XmlElement FechaEmision = xmlDoc.CreateElement("ds", "FechaEmision", "");
            FechaEmision .InnerText = DateTime .Now.ToString();

            xmlDoc.AppendChild(FacturaElectronica);
            FacturaElectronica.AppendChild(clave);
            FacturaElectronica.AppendChild(consecutivo);
            FacturaElectronica.AppendChild(FechaEmision);

            xmlDoc.Save(@"C: \Users\Public\Documents\Factura.xml");
        }