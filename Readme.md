1. Creating thr Application
- Console App
	- Desktop App
- Project Important Sections
	- References
		- Standard .NET Assembly(?) references used for programming
			- They contains Standard .NET Classes
		- All these Assemblies (aka Libraries) are available from
			- Base Class Libraries (BCL) aka Framework Class Libraries (FCL)
			- System.dll
				- Highest level assembly/library in .NET
				- Contains classes for
					- DataTypes
					- Console
					- .... and many more
			- System.Data
				- Contains all classed for Database programming
			- System.Core
				- USed for LINQ
			- System.Xml
				- Used for XML Programming
			- System.Xml.Linq
				- Used for LIQ to XML
			- Microsoft.CSharp
				- C# Compiler Services
			- System.Net.Http
				- For Network Programming
				
	- Configuration File
		- App.Config
			- Application Configuration for Desktop Apps
				- WinForm , WPF, Comsole Apps
			- Contains .NET Framework Configuration to Execute the app 
		- Web.Config
			- COnfiguration for Web Apps
	- Code Files
		- Source Code
========================================================================================
1. When any class is supposed to be used in the code file, make sure thst, its namespasce(?) 
is imported in the code file.
	- Namespace, is a logical collection of classes, related or not related with each othee
		but used for similar types of operations.
			- Related means, classes may have Based->Derived (inheritance) relationship
			- May be 'sealed' classs, means cnnot be derived, independant classes
		- All classes perform operations on similar resources
			- e.g. System.Data namspace
					- all classes are used for Database programming
			- e.g. System.IO
					- all classes are used for Stream or File operations
					

2. After Successful build the Project generats 3 files using Visual Studio
	- Assembly File
		- .exe / .dll
		- Every .NET Application generates assembly after successful build
			- .exe assembly
				- Self-Executable in .NET Framework
				- Console Appp, Windows Desktop App and Windows Service
			- .dll assembly
				- Must be used or referred in .exe assembly to get executed
				- Classs Library Projects
				- ASP.NET Web Forms, MVC Apps and Web API 
	- Deployment Configuration file
		- .exe.config
			- Merging between Assemble and Application Configuration File 
				(App.config / Web.confile)
	- Debugger File
		- .pdb file
			- Used in case of Code Debugging
			- This file will be generated only in case of Debug Mode
	- Each .NET Application Have 3 Modes	
		- Coding Mode, we write the code
		- Debug Mode	
			- Run the application in Debugging mode by applying breakpoints
			- Generally used to verify if the code works correctly
		- Running Mode or Production Mode
			- On Production Machine
			- No debugging is allowed
	- Use F5 to run the project in VS
	- F10 to debug using Step-Over
		- Skip the function / method call in debugging
	- F11 to debug using Step-into
		- Enter into method call and also debug easch line in called method
==========================================================================================
Access Specifiers
- Define the scope of Accessing Classes, Method,Proprties of the application / namespaces
	to other class or assembly
- public, accessible everywhere
- private, only within the class
	- Default for Methods, data members and propertis of the class
- protected, within the class and in derived class
- internal, only in containing namespace
	- Default for Class
- protected internal, only in containing namespace and in the derived class of other 
	namespace
=========================================================================================
DataTypes
1. Numeric
	- byte, 8 bits, System.Byte, 0-256
	- short and ushort, 16 bits, System.Int16,
	- int and uint, 32 bits, System.Int32
	- long and ulong, 64 bits, System.Int64
	- float, 32 bits, System.Float32
	- double, 64 bits, System.Float64
	- decimal, 64bytes, System.Decimal, 
	- BigInt highest size
2. String
	- char, 2 bytes, Uni-Code characters, special characters and Symbols, System.Char
	- string
		- Reference Type
		- System.String class
3. Date, System.Date
4. Boolean, bool, True / False
5. Object, object (keyword), System.Object 
==========================================================================================
Create an Instance of Class
- Using the 'new' keyword
- If the class is not instantiated using 'new' then the execption will be thrown as
	"Obnject reference is not set to an instance of the object"
==========================================================================================
- The .NET Framework provides following Services to the Application
	- Compiles the Source Code using 
		- Common Language Service (CLS)
			- Verifies LHS = RHS, if match then only the line is interpreted and compiles
			- Syngtax Check
				- Statement termination using ';'
			- Data Type Check with allowed value based on size of the data type
		- Base Class Library or Framework Class Library
			- Make sure that, the classes are referred with its namespaces
			- If the class is used from the different library, then that librery must
				be referenced in current project.
	- Common Language Runtime (CLR)
		- Accepts the Compiled Assembly as Input (.exe /.dll)
		- Uses Just-In-Time compiler to Execute the assermbly using fopllwoing step
			- Load the Assembly in AppDomain (Precess provided by CLR to the executing App)
		- Provides Memory Management

Source Code ----> Language Specific Compiler With Standard Classes (CLS and FCL)
					---> Output into Assembly (.exe / .dll) 
							---> Input to CLR
									--> Execute it with Jit and Memory Management

.NET Framework Supports XCOPY deployment. 
	- Copy assembly from Dev. machine to Prod. machine, provided the Prod. machine has
		.NET Framework, the app will work.
==========================================================================================
What CLR class contains?
1. Data Members
2. Method
3. Properties
	- Intelligent fields
		- They provide a logic to execute the Private Data member
			- set(value), use to set the 'value' to the data member
				- Internally this is a setter() method
			- get, return the value of the data member
				- Internally this is a getter() method
	- Type properties
		- Read/Write
			- getter and setter
		- Read only properties
			- only getter
	- New Sytax for properties C# 3.0+ 
		- Property w/o private data member also known as "AUTO-IMPLEMENTED-PROPERTIES"
		- USe Auto-Implemenetd proeprties fopr creating Data Classes or Entity Classes
		
4. Events

==========================================================================================
Exercise with Self Study
1. Learn the Inheritance in C#
	- Explore the following
		- Protected Access Specifier
		- Overloading
		- Overriding
		- Shadowing
2. Learn Boxing and UnBoxing