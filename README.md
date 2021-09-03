# NIC-Deatils-DLL
DLL for the get details from National Identity Card using C# .NET Framework

# How to use

You must add this dll to your project before using it.

👉First go to the solution explorer on the right side and right click on the references under your project.

👉Then select add references and then click on the browse button, select dll file and click on the ok button.

as follows

![ezgif com-gif-maker](https://user-images.githubusercontent.com/80079235/131951991-36dc8f6b-1884-424b-9785-ba0042aa68f8.gif)

👉Then you need to import this code segment

    using SMDgetNicDetails;

as follows

![Screenshot_2](https://user-images.githubusercontent.com/80079235/131953600-bf2d43bf-e264-49f9-916b-30feefde42e9.png)

Now you can create object using GetNicDetails class

    GetNicDetails nic;
    
Then you should pass the Sri Lanka NIC (old/new) as a string using parameterized constructor
    
    nic = new GetNicDetails("200013423310");

Now you can access the property one by one using nic object.

Here, when a wrong nic is given, the return is 0 which you can use when validations.

# Screen Shot👇

![Screenshot_1](https://user-images.githubusercontent.com/80079235/131954593-849be04a-8ce0-46ed-b6ea-ceae43db982e.png)
