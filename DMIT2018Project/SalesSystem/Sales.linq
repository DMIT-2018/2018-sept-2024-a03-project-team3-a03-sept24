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
	//testing situation
	
	
	
	
	
	
	
	
	//creates a new sale
		//needs a valid employeeID
		
	//addCartItem
		//add a new item that does not exist in order yet
		//add a that same item again and show that the quantity just increments by new addition
	//editCartItem
		//edit that previously added cart item back to the original amount that was added
	//deleteCartItem
		//this is what happens when the trash button is pressed on an item in cart view
		
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

public class addCartItem(int saleId, int quantity)
{
	//this will get called on 'continue shopping' page when the 'add' button is pressed, and will add the number in the fillable feild. 
	//it will check the sale its being added to see if that StockItemID already exists,
		//if it does not, it will create a new saleDetails,
		//if it does, it will add quantity to the already existing quantity
	//save
}

public class editCartItem(int saleId, int saleDetailId, int newQuantity)
{
	//this will get called when someone presses the refresh icon, and whatever is in that input field is newQuantity

	//SaleDetails cartItem = SaleDetails.Where(saleId and SaleDetailId).FirstAndOrDefault(); 
	//cartItem.Quantity = newQuantity;

	//cartItem.Quantity == 0 ? delete SaleDetail : save
}

public class deleteCartItem(int saleId, int saleDetailId)
{
	//editCartItem(saleId, saleDetailId, 0);
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

	if (saleID == 0)
	{
		throw new ArgumentNullException("No order id was supply");
	}
	
	//if saleID does not exist in Sales table: errorList.Add(new Exception("Sale ID does not exist"))

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
	
	
	
	#endregion


	// begins with checking valid employee user
	if (ValidateUser(1) == true)
	{
	}
	// so what im thinking for
	
	
	
	//just holder to keep from errors when outlining
	SaleView holder = GetSale(1);
	return holder;
}



#endregion


#region View Models
public class SaleDetailsView
{
	public int SaleID { get; set; }
	public int SaleDetailID { get; set; }
	public int StockItemID { get; set; }
	public int SellingPrice { get; set; }
	public int Quantity { get; set; }
	public bool RemoveFromViewFlag { get; set; }
}

public class SaleView
{
	public int SaleID { get; set; }
	public int SaleDate { get; set; }
	public string PaymentType { get; set; }
	public int EmployeeID { get; set; }
	public decimal Tax { get; set; }
	public decimal Subotal { get; set; }
	public int? CouponID { get; set; }
	//PaymentToken??
	public bool SaleProcessedFlag { get; set; }
	public List<SaleDetailsView> SaleDetails { get; set; } = new List<SaleDetailsView>();
}

public class SalesRefundView
{
	
}

public class SalesRefundDetailsView
{
	
}

#endregion