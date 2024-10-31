<Query Kind="Program">
  <Connection>
    <ID>ef74c716-91fc-4ace-9753-ea248f4e86aa</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Server>.</Server>
    <Database>eTools2023</Database>
    <DisplayName>eTools2023-Entity</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

#region Driver
void Main()
{
	//

}
#endregion

#region test methods
#endregion

#region support methods
public bool ValidateUser(int loginId)
{
	// loginId !exists ? errorlist.add(please enter valid loginID)
	// PositionID != SalesReturn Role ? errorlist.add(employee {employee name} not authroized for this service)

	return true; //this is just here as placeholder
}

public class editCartItem (int saleId, int saleDetailId, int newQuantity)
{
	//this will get called when someone presses the refresh icon, and whatever is in that input field is newQuantity
	
	//SaleDetails cartItem = SaleDetails.Where(saleId and SaleDetailId).FirstAndOrDefault(); 
	//cartItem.Quantity = newQuantity;
	//save
}

#endregion


#region methods
// addeditsale
//if editing a sales items, check if the OrderPlaced flag has been triggered or not. If it has, then ItemsView cannot be edited. 

//make sure only if the order is new and created that SaleProcessed is set to false.  

//refundsale

public class GetCategories { }
public class GetItemsByCategoryID { }
public class SaveSales { }
public class GetSaleRefund { }
public class SaveRefund { }

public SaleView GetSale(int saleID)
{
	//  Business Rules
	//	These are processing rules that need to be satisfied
	//		for valid data
	//		rule:	order id must greater than 0 

	if (saleID == 0)
	{
		throw new ArgumentNullException("No order id was supply");
	}

	return Sales
				.Where(x => x.SaleID == saleID)
				.Select(x => new SaleView
				{
					SaleID = x.SaleID,
					EmployeeID = x.EmployeeID,
				}).FirstOrDefault();
}

public SaleView AddEditSale(SaleView saleView) //(int loginId)
{
	#region error list
	///////// ACCESS AND AUTHENTICATION
	//Check that the system requires users to log in
	//Verify that access is restricted to those in the SalesReturns Role
	//Confirm that sales and/or returns are handled by an Associate or Store Manager.
	//Ensure the Employee's full name is displayed on the form.

	///////// SALES
	//Verify that only one cart per sale is allowed

	// Buisness Rules
	//Ensure there are no duplicate items in the cart
	//Confirm that discontinued products are not displayed or added
	//Ensure that a quantity is specified when adding items
	//Confirm that added items go to the shopping cart
	//Confirm that the number of items in the cart is shown in View Cart

	//Checkout -- VIEW CART
	//Item
	#endregion


	// begins with checking valid employee user
	if (ValidateUser(1) == true)
	{
	}
	// if there are no items in error list, then we can continue to 
	
	
	
	//just holder to keep from errors when outlining
	SaleView holder = GetSale(1);
	return holder;
}



#endregion


#region View Models
//ItemsView
public class CartView
{

}

//SaleView
public class SaleView
{
	public int SaleID { get; set; }
	public string PaymentType { get; set; }
	public int EmployeeID
	public int
	public decimal Subotal { get; set; }
	public decimal Tax { get; set; }
	public decimal Total { get; set; }
	public bool SaleProcessedFlag { get; set; }
	public List<CartView> OrderDetails { get; set; } = new List<CartView>();
}

//SalesRefundView

//SalesRefundDetailsView

#endregion