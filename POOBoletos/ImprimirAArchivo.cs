namespace POOBoletos
{
    internal class ImprimirAArchivo
    {
        public void Imprimir(string texto) 
        {
         string directorio = Environment.CurrentDirectory;
            string nombreArchivo = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            string rutaArchivo = Path.Combine(directorio, nombreArchivo);

            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                
                sw.WriteLine(texto);
            }
        }
        public void Imprimir(List<ConceptoDeVenta> conceptos)
        {
            string directorio = Environment.CurrentDirectory;
            string nombreArchivo = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            string rutaArchivo = Path.Combine(directorio, nombreArchivo);

            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var concepto in conceptos)
                {
                    sw.WriteLine($"Boleto #{concepto.NumeroBoleto} - Tipo: {concepto.TipoBoleto} - Precio Unitario: {concepto.ValorUnitario:C} - Importe: {concepto.Importe:C}");
                }
            }

            MessageBox.Show($"Boletos guardados en: {rutaArchivo}");
        }
       

    }
}
