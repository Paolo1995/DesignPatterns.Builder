# What is the Builder Design Pattern?

The Builder Design Pattern builds a complex object using many simple objects and using a step-by-step approach. The Process of constructing a complex object should be generic so that the same construction process can be used to create different representations of the same complex object.

So, the Builder Design Pattern is all about separating the construction process from its representation. When the construction process of your object is very complex then only you need to use to Builder Design Pattern. If this is not clear at the moment then don’t worry we will try to understand this with an example.

Please have a look at the following diagram. Here, Laptop is a complex object. In order to build a laptop, we have to use many small objects like LCD Display, USB Ports, Wireless, Hard Drive, Pointing Device, Battery, Memory, DVD/CD Reader, Keyboard, Plastic Case, etc. So, we have to assemble these small objects to build laptop complex objects
