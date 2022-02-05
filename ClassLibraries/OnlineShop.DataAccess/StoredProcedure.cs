using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.DataAccess
{
    class StoredProcedure
    {
        public StoredProcedure()
        {
        }

        public enum Name
        { 
            sp_StateProvinceByID_Select,
            sp_StateProvinces_Select,
            sp_ShopCategories_select,
            sp_ShopCategory_Insert,
            sp_ShopCategory_Delete,
            sp_ShopCategoriesByShopID_Select,
            sp_ShopCategoryImage_Select,
            sp_ShopByCategoryID_Select,
            sp_ShopImage_Select,
            sp_ShopByID_Select,
            sp_Shop_Insert,
            sp_Shops_Select,
            sp_ShopSearch_Select,
            sp_ShopSearchCareerAdvanced_Select,
            sp_ShopSearchAddressAdvanced_Select,
            sp_ShopSearchContactAdvanced_Select,
            sp_ShopSearchFT_Select,
            sp_Shop_Update,
            sp_ShopByCode_Select,
            sp_ShopByID_Delete,
            sp_ShopByCategoryID_Delete,//by elahe 1/16
            sp_ShopsByEndUserID_Select,
            sp_ShopAddressInfoByCategoryID_Search,
            sp_ShopContactInfoByCategoryID_Search,
            sp_Product_Update,
            sp_Product_Insert,
            sp_ProductSearch_Select,
            sp_ProductSearchAdvanced_Select,
            sp_ProductByID_Delete,
            sp_ProductByID_Select,
            sp_ProductsByShopID_Select,
            sp_ProductsByShopIDPaged_Select,
            sp_ProductImageByID_Select,
            sp_Category_Insert,
            sp_CategoryByID_Select,
            sp_Categories_Select,
            sp_Category_Update,
            sp_CategoryImageByID_Select,
            sp_CategoryByID_Delete,//Added by elahe
            sp_EndUser_Insert,
            sp_EndUser_Select,
            sp_EndUsers_Select,
            sp_EndUserByRegistrarName_select,
            sp_EndUsersByRegistrarName_select,
            sp_EndUserRoles_Select,
            sp_EndUserRoleByID_Select,
            sp_EndUserRole_Update,
            sp_EndUserRole_Insert,
            sp_EndUserPersonalInfo_Insert,
            sp_EndUserPersonalInfoByEndUserID_Select,
            sp_EndUserCareerInfoByEndUserID_Select,
            sp_EndUserCareerInfo_Insert,
            sp_EndUserAddressInfo_Insert,
            sp_EndUserAddressInfoByEndUserID_Select,
            sp_AddressInformationByEndUserID_Select,
            sp_EndUserContactInfo_Insert,
            sp_EndUserContactInfoByEndUserID_select,
            sp_EndUserAddressInfo_Update,
            sp_EndUserCareerInfo_Update,
            sp_EndUserContactInfo_Update,
            sp_EndUserPersonalInfo_Update
       



        }
    }
}
