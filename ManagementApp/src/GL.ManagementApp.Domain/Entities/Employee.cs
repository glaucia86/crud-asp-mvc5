using System;
using System.Collections.Generic;

namespace GL.ManagementApp.Domain.Entities
{
    public class Employee
    {
        /// <summary>
        /// Id do Empregado
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Primeiro Nome
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Sobrenome
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Data de Criação do Cadastro do Empregado
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Ativo (se o empregado está ativo)
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Cargo Ocupado
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// Relacionamento de Employee para Address (1 para n)
        /// </summary>
        public ICollection<Address> Addresses{ get; set; }

    }
}
