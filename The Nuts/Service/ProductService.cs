using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsDAC;
using TheNutsVO;

namespace The_Nuts.Service
{
    public class ProductService
    {
        public bool RegisterProduct(ProductInfoVO pro)
        {
                ProductOrderDAC dac = new ProductOrderDAC();
                return dac.RegisterProduct(pro);
        }
        public bool UpdateProduct(ProductInfoVO pro)
        {
                ProductOrderDAC dac = new ProductOrderDAC();
                return dac.UpdateProduct(pro);
        }
        public List<ProductInfoVO> GetAllProData()
        {
            ProductOrderDAC dac = new ProductOrderDAC();
            return dac.GetAllProData();
        }
        public void GetProductInfoByID(string ProductCode)
        {
            //ProductOrderDAC dac = new ProductOrderDAC();
            //return dac.GetProductInfoByID(ProductCode);
        }
    }
}
