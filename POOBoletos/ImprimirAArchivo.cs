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
    }
}
