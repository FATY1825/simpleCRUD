﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace simpleCRUD
{
    class Cliente
    {
        //propiedades
        public int _clienteId { get; set; }
        public string _names { get; set; }
        public string _address { get; set; }
        public int _telephon { get; set; }
        public int _mobile { get; set; }

        //instancias a la clase Crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla Cliente
        public MySqlDataReader getAllCliente()
        {
            string query = "SELECT clienteId,nombres,address,telephon,mobile FROM cliente";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditCliente(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO cliente(names, address, telephon, mobile)" + 
                    "VALUES ('"+ _names +"', '"+ _address +"', '"+ _telephon +"', '"+ _mobile +"')";

            }
            else if ()

        }
    }
}
