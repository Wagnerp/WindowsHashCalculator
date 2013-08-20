WindowsHashCalculator
=====================

A calculator of popular hashes (md5, sha1, sha256) for a file. 

Motivation: no reliable windows programs found in internet for this simple task.

--

Here is only one file, you can simply save it in your Windows under mysh.cs name,

compile it:

C:\Users\You\Documents>\Windows\Microsoft.NET\Framework\v3.5\csc mysh.cs

...

C:\Users\You\Documents>


then do the following:

C:\Users\You\Documents>mysh

Usage:

mysh -algoName fileName

(where -algoName is -md5 or -sha1 or -sha256)

C:\Users\You\Documents>mysh -md5 mysh.cs

9c55192883453990b9fb2a95cd28c999

C:\Users\You\Documents>mysh -sha256 mysh.cs

c8606e89fd6234cf0995c9039a033b87d911df980cc74c36d702f1963e4a9eec

C:\Users\You\Documents>mysh -sha1 mysh.cs

d251e2804135dbf729b630df0c09b1428619fe05

C:\Users\You\Documents>
