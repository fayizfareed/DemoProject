# DemoProject
ForClient
01. This project is developed using .Net core and the Visual Studio 2019 IDE
02. Visual Studio Solution contains two project.
    * DemoProject
          - MVC Project which will display all the jobs which found in the RX_job table. 
          - And also this has a option to make the job completed according to certain conditions.
          - It has controller call homecontroller and inside that it has method call index which retrieve all the RX_job data when the site loads
          - In the sam controller there is method call update which make the job status to complete.
          - End Point : https://{domain}/
    * DemoAPI
          - Rest API Which will return job status summery in JSON.
          - This project has Get method inside GetDataController, This will return Job Status JSON.
          - End Point : https://{domain}/api/GetData/
          
03. ORM are not used becuase of the project scope (Demo Project)
04. Used SQLCommand to retrieve data
05. UI are not designed becuase of project scope (Demo Project)
      
