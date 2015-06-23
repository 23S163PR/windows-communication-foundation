using System.ServiceModel;

namespace *
{
	[ServiceContract(Namespace = "http://cinema.org/")]
	public interface IModerator
	{
		[OperationContract]
		void CreateShow();

		[OperationContract]
		void EditShow();

		[OperationContract]
		void ManageFeedback();
	}
}
