namespace POOBoletos
{
    internal class IMpresionAImpresora : IImpresion 
    {
        public void Imprimir(string texto) 
        {
         Console.WriteLine($"Imprimiendo en impresora: {texto}");
        }
    }
    
}
