# LeaveManagementSystem_DotNetAssignment
Efficient and seamless leave management at your fingertips!
Teacher Leave Management System allows administrators to easily track and manage leave requests from teachers, ensuring transparency and streamlined approval processes. With the power to create, edit, and delete leave records, this system revolutionizes the way schools handle teacher leave applications.

Dont forget to do the following before building:
**
Change server name in connection string 
add-migration migration-name
update-database 
**
In database:

INSERT INTO [dbo].[AspNetRoles]
           ([Id],[Name],[NormalizedName])
     VALUES
           ('43064954-d35d-49ef-9cf2-abe84345e891','User','USER'),
		   ('c87fa796-d513-4c1b-aef5-2bfd73e7a439','Manager','MANAGER')

Insert into AspNetUserRoles values
		   ('4ba40cf0-c224-43f9-9d16-406662ebcc56','c87fa796-d513-4c1b-aef5-2bfd73e7a439'),
		   ('888c4fbf-3649-4ac0-a71c-12e4bfccf63a','c87fa796-d513-4c1b-aef5-2bfd73e7a439'),
		   ('6876a6c7-e3be-4d44-8857-f619f27ce295','43064954-d35d-49ef-9cf2-abe84345e891'),
		   ('ac0d1466-9a7c-43f1-a360-06d75b30a739','43064954-d35d-49ef-9cf2-abe84345e891')

Replace user id by randomly generated id.

This Teacher Leave Management System is designed with user experience and security in mind, featuring a comprehensive set of tools for both administrators and users. Key functionalities include:

Authentication: Secure login and registration ensure that only authorized individuals can access sensitive data.
Authorization: Role-based access control (Admin, Manager, and Staff) guarantees that users only have access to the features relevant to their role.
CRUD Operations: The system supports full Create, Read, Update, and Delete capabilities, allowing easy management of leave records.
Pagination: Manage large datasets with ease through pagination, ensuring smooth navigation and better performance.
Sorting: Sort teacher leave requests by date, number of days, or teacher name, enabling quick access to the most relevant data.
Searching: A powerful search functionality ensures you can find specific leave requests fast, whether by teacher name, leave date, or other parameters.
With these features, this system empowers school administrators to manage teacher leave efficiently while maintaining security and usability.

Firstly, this is the homepage of the web application.

![Loggingin](HomePage.png)




![register](Register.png)




![login](Login.png)




![login2](Loggedin.png)




![TL](TeacherLeaves.png.png)



![create](create.png)



![afterCreate](afterCreate.png)



![deleteDeny](deleteDeny.png)




![deleteConfirm](delete.png)




![afterDelete](create.png)



![edit](edit.png)



![afterEdit](afterEdit.png)


![search](search.png)


![sort](sort.png)


![sort2](sort2.png)
