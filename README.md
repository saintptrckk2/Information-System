<div align="center">
  <br />
    <a href="https://www.facebook.com/saintptrckk" target="_blank">
    <img src="https://github.com/saintptrckk2/Information-System/blob/main/photo/icon-modified.png" alt="icon-modified">
    </a>
  <br />

  <div>
    <h1 align="center"> Information System <br /> by <br /> Patrick Padilla Maloto <br /> Gwapo</h1>
  </div>
</div>

## 📋 <a name="table"> Table of Contents </a>

1. 🤖 [Introduction](#introduction)
2. ⚙️ [Tech Stack](#tech-stack)
3. 🔋 [Features](#features)
4. 🤸 [Quick Start](#quick-start)
5. 🔗 [Assets](#assets)

##

## <a name="introduction"> 🤖 Introduction </a>

A Pupil information System that can easily manage Pupil's information featuring Administrative tools for Gerating QR Code using their LRN, Add, Edit and Deleting Pupil's Information.

## <a name ="tech-stack"> ⚙️ Tech Stack </a>

- Visual Studio Community 2022
- SQL Server Express
- SQL Server Management Studio (SSMS)

## <a name ="features"> 🔋 Features </a>

👉🏻 **Admin Authentication**: Cannot be accessed by and outsider or other School staff if they don't have the admin Username and Password.

👉🏻 **Add Pupil**: School Admin can Add Pupil.

👉🏻 **Edit Existing Pupil**: School Admin can easily Edit existing Pupil's Information.

👉🏻 **Delete Pupil**: School Admin can easily delete dropped or graduated pupil

👉🏻 **Generate QR Code**: School Admin can easily Generate Unique QR Code for a Pupil using Pupil's unique LRN.

👉🏻 **Ease of Use**: School Admin can easily learn how to use the Application because it has a user-friendly Interface.

👉🏻 **Pupil Photo**: each Pupil recorded has their own Picture attached.

## <a name="quick-start"> 🤸 Quick Start </a>

Follow these Steps to set up the project locally on your machine:

**Prerequisites**

Make Sure you have the following Installed on you Machine.

- [Git](https://git-scm.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio(SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

**Check Git if it's already Installed**

```bash
git -v
```

**Make sure you have the following modification installed on a Visual Studio 2022:**

- ASP.NET and web development
- Azure development
- .NET desktop development
- Data storage and Processing
- Visual Studio extension development

**Configure the SQL Server 2022 Configuration Manager**

- go to SQL Server Configuration Manager
- SQL Server Network Configuration
  - Protocols for SQLEXPRESS
    - TCP/IP Properties
      - IP Address
        - IPAll
          - Set TCP Port tp 1433 (can be set to any)

**Configure the IP Address**

- set the IP address IPv4 to 192.168.1.2
- set the Default Gateway to 192.168.1.1

**Configure Windows Defender Firewall**

- go to Windows Defender Firewall
  - Advanced Setting
    - Inbound Rules
      - New Rule
        - Set to Port (TCP Port of SQL Server IPAll)
        - All Programs
        - Allow the connection
        - Select All [Domain, Private, Public]
        - Name it

**Configure The SQL Server Management Studio**

- Connect to Server 192.168.1.2, 1433
- Create New Database and name it to "Baluarte"
- go to Baluarte Database
- go to database query

**Database query**

execute the following query:

```bash
create table Pupils(
	LRN INT PRIMARY KEY,
	Firstname NVARCHAR(50),
	Lastname NVARCHAR(50),
	GradeLevel NVARCHAR(10),
	Section NVARCHAR(10),
	ContactNumber NVARCHAR(15),
	Picture VARBINARY(max)
);

create table Admins(
    AdminId INT PRIMARY KEY,
    Username NVARCHAR(15),
    Password NVARCHAR(15)
);
```

**Cloning the Project**

```bash
git clone https://github.com/saintptrckk2/Information-System.git
cd Information-System
```

**Make sure you have this NuGet Package installed on the project**

- **QRCoder** by raffael Herrmann -v 1.6.0
- **System.Data.SqlClient** by Microsoft -v 4.8.6

**Modify the Connection strings**

- Set the ConnectionString according to SQL Server Database connection String

**Running the Project**

- Open the project admin.sln and run the program.

## <a name="assets"> 🔗 Assets </a>

The Program assets can be found [here]().
