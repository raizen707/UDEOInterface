using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEOInterface.Class
{
    public class EmployeeListSource : Component, IListSource
    {
        public EmployeeListSource() { }

        public EmployeeListSource(IContainer container)
        {
            container.Add(this);
        }
        #region IListSource Members

        bool IListSource.ContainsListCollection
        {
            get { return false; }
        }

        System.Collections.IList IListSource.GetList()
        {
            BindingList<Employee> listaEmpleado = new BindingList<Employee>();

            if (!this.DesignMode)
            {
                listaEmpleado.Add(new Employee("Steveen, Blanco", 26000000));
                listaEmpleado.Add(new Employee("Pedro, Fernandez", 19600000));
                listaEmpleado.Add(new Employee("Luka, Modrick", 19000000));
                listaEmpleado.Add(new Employee("Cristiano, Ronaldo", 16000000));
                listaEmpleado.Add(new Employee("Daenerys, Targerian", 15700000));
                listaEmpleado.Add(new Employee("Walter, White", 15700000));
            }

            return listaEmpleado;
        }

        #endregion
    }
}
