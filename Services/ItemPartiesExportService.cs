using SoftPos.Data.Account;
using SoftPos.Data.Setting;
using SQLite;

namespace SoftPos.Services
{
    public class ItemPartiesExportService
    {
        private readonly SQLiteAsyncConnection _database;

        public ItemPartiesExportService(SQLiteAsyncConnection database)
        {
            _database = database;
        }
        public async Task<bool> SaveProducts(List<Product> products)
        {
                foreach (var product in products)
                {
                   await _database.InsertAsync(product);
                }
            return true;
        }

        public async Task<bool> SaveParties(List<AccountLedger> parties , string type)
        {
            foreach (var party in parties)
            {
                if(type == "Customer")
                {
                    party.AccountGroupId = 26;
                }
                else
                {
                    party.AccountGroupId = 22;
                }
                await _database.InsertAsync(party);
            }
            return true;
        }

    }
}
