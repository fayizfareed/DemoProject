# DemoProject
ForClient

Development Instruction
------------------------
01. This project is developed using .Net core and the Visual Studio 2019 IDE
02. Visual Studio Solution contains two project.
    * DemoProject
          * MVC Project which will display all the jobs which found in the RX_job table. 
          * And also this has a option to make the job completed according to certain conditions.
          * It has controller call homecontroller and inside that it has method call index which retrieve all the RX_job data when the site loads
          * In the sam controller there is method call update which make the job status to complete.
          * End Point : https://{domain}/
    * DemoAPI
          * Rest API Which will return job status summery in JSON.
          * This project has Get method inside GetDataController, This will return Job Status JSON.
          * End Point : https://{domain}/api/GetData/
          
03. ORM are not used becuase of the project scope (Demo Project)
04. Used SQLCommand to retrieve data
05. UI are not designed becuase of project scope (Demo Project)
      
Deployment Instruction
------------------------------
01. Download project from github repo (https://github.com/fayizfareed/DemoProject)
02. Exctract the zip
03. For MVC Project (Display Job Details)
		* Go To \DemoProject\bin\Release\netcoreapp3.0\
		* Copy Folder 'publish'
		* Past It Inside 'C:\inetpub\wwwroot'
04 For Web API (Get Job Status in JSON)
		* Go To \DemoAPI\bin\Release\netcoreapp3.0\publish
		* Copy Folder 'publish'
		* Past it Inside 'C:\inetpub\wwwroot' with Different Name
05 Follow Below Instruction For Two Projects To Host on IIS
		* Open IIS
		* Create New Application
		* Select Path where web files are located (Location where pasted the publish folder)
		* do settings according to relavant field like domain, port etc
		* For More Detailed Info (https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/iis/?view=aspnetcore-3.1)
06. End Point For MVC : https://{domain}/
07. End Point For API : https://{domain}/api/GetData/
		