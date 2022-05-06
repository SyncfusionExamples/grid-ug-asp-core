UG-automation-sample-ASP.NET Core

Step to run the project:
1.	Unzip the project in different location
2.	Run the project by double clicking the EJ2GirdBrowserSample.sln file
3.	Make sure it is running in VS studio or Equivalent program. Run using the IIS Express Button.

Step to adding new samples:
First please refer the existing project structure inside the below folder for your clarification.

Ref: “EJ2GridBrowserSample/Controllers”
        “EJ2GridBrowserSample/Views”
        “EJ2GridBrowserSample/Views/Shared/Layout.cshtml”

1.	If you want to add a new sample, create a new controller in Controller’s folder and create folder inside the View folder name it as per the requirement and add view file (grid.cshtml) and which help to view our requirement on browser window.
2.	Copy necessary feature’s sample code from https://ej2.syncfusion.com/aspnetcore/documentation/grid site under the file extension .cs and paste it into your controller file. Re-name the controller function as per the view file name.
3.	Now copy code from the same site but from the file extension CSHTML and paste it into your view file. 
4.	Make sure the same view file name is used in the controller function definition.
5.	Add another button for your new sample under the folder view/shared/Layout.cshtml using the tag <e-accordion-accordionitem> route it to our controller using proper "href" reference using anchor tag.
