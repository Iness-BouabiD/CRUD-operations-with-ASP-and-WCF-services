using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class Service : IService
{
	public List<Eleve> GetStudent()
	{
		ENSATEntities obj = new ENSATEntities();
		var x = from n in obj.Eleve select n;
		return x.ToList<Eleve>();
	}
	public void InsertStudent(Eleve model)
	{
		ENSATEntities obj = new ENSATEntities();

	}

	
}
