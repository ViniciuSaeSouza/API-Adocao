using API_Adocao.Domain.Enums;

namespace API_Adocao.Infrastructure.Persistence
{
    public class Pet
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataResgate { get; private set; }
        public Especie Especie { get; set; }
        public int Adotado { get; set; }

        public Pet(int id, string nome, int idade, DateTime dataResgate, Especie especie, int adotado)
        {

            if (dataResgate > DateTime.Now)
            {
                throw new Exception("Data futura inválida!");
            }
            Id = id;
            Nome = nome;
            Idade = idade;
            DataResgate = dataResgate;
            Especie = especie;
            Adotado = adotado;
        }
    }
}
