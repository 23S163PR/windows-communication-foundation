using System.ServiceModel;

namespace *
{
	[ServiceContract(Namespace = "http://cinema.org/")]
	public interface ICustomer
	{
		[OperationContract]
		void ViewAvailableTickets();

		[OperationContract]
		void BookTicket();

		[OperationContract]
		void CancelBooking();

		[OperationContract]
		void AdjustBooking();

		[OperationContract]
		void LeaveFeedback();
	}
}
