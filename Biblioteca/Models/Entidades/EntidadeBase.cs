namespace Biblioteca.Models.Entidades
{
    /* 
        Um GUID é um número inteiro de 128 bits (16 bytes) que você pode usar em 
        todos os computadores e redes sempre que um identificador exclusivo for 
        necessário

    =====================================================================================

    Use o modificador abstract em uma declaração de classe para indicar que uma 
    classe se destina somente a ser uma classe base de outras classes, não instanciada 
    por conta própria

    */
    public abstract class EntidadeBase
    {
        public string ID { get; set; }

        public EntidadeBase() 
        {
            // Gerar um identificador único
            ID = Guid.NewGuid().ToString();
        }
    }
}
