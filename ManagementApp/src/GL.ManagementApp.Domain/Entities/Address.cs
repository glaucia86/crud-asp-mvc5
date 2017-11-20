using System;

namespace GL.ManagementApp.Domain.Entities
{
    public class Address
    {
        /// <summary>
        /// Gerando um novo guid todas as vezes que gerar um novo endereço
        /// </summary>
        public Address()
        {
            AddressId = Guid.NewGuid();
        }

        /// <summary>
        /// Id do Endereço
        /// </summary>
        public Guid AddressId { get; set; }

        /// <summary>
        /// Endereço
        /// </summary>
        public string PublicPlace { get; set; }

        /// <summary>
        /// Número do Endereço
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Complemento do Endereço
        /// </summary>
        public string AddressComplement { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// País
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Chave Estrangeira (FK)
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Relacionamento de Address com Employee (1 para n)
        /// </summary>
        public virtual Employee Employee { get; set; }
    }
}
