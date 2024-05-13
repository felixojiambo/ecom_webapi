using ecom.Models;


namespace ecom.Repository
{
    public interface IShipmentRepository
    {
        List<Shipment> GetAll();

        Shipment GetById(int id);

        void Insert(Shipment obj);

        void Update(Shipment obj);

        void Delete(int id);

        void Save();

    }
}