using System;
using System.IO;
using System.Xml.Serialization;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class GenerateXML : IGenerateFile
    {
        private string fileName = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        private FileStream fileStream;

        public void SaveFile(Employee employee)
        {
            fileStream = new FileStream(fileName, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, employee);

            Console.WriteLine($"Salário para o funcionário : {employee.Name} " +
                $"gerado com sucesso em : {fileName} \n");
        }
    }
}

