# Vidly
Web Application for a Video Rental Store using ASP.Net MVC, RestFul Services with Web API , C# and Entity Framework. 
-I have used Bootstrap , Chrome Developer Tools and CSS Overrides for FrontEnd.
- Has Client and Server Side Validation
- Authentication and Authorization

Business Logic:
1) A memeber who is less than 18 years old can have only "Pay As you Go" as Membership Type - created Custom Validation and added attribute to the property.


After cloning the repository , you can access the applciaiton with two user roles:
1) Video Rental Store's - Staff Member - 
has a) Authorization to View only Customers and Movies Page 
    b) Cannot Edit or Delete Customers or Movies
    Login with - guest@vidly.com
          Pass: Guest123$
          
2) Video Rental Store's - Manager - 
has a) Authorization to Edit and Delete Customers and Movies Page 
    Login with - admin@vidly.com
          Pass: Admin123$          
