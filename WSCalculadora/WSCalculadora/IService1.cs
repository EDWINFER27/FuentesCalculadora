using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSCalculadora
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Double GetSuma(double Numero1, double Numero2);

        [OperationContract]
        Double GetResta(double Numero1, double Numero2);

        [OperationContract]
        Double GetMultiplicacion(double Numero1, double Numero2);

        [OperationContract]
        Double GetDivision(double Numero1, double Numero2);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        double Resultado = 0.0;
        string stringValue = "Hello ";

        [DataMember] 
        public double Suma {
            get { return Resultado; }
            set { Resultado = value; }
        }

        [DataMember]
        public double Resta
        {
            get { return Resultado; }
            set { Resultado = value; }
        }

        [DataMember]
        public double Multiplicacion
        {
            get { return Resultado; }
            set { Resultado = value; }
        }
        [DataMember]
        public double Division
        {
            get { return Resultado; }
            set { Resultado = value; }
        }
    }
}
