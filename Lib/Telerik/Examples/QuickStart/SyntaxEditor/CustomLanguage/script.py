num1 = 15
num2 = 12
  
# Adding two numbers 
sum = num1 + num2 
  
# printing values 
print("Sum of {0} and {1} is {2}" .format(num1, num2, sum)) 


fruits = ["apple", "banana", "cherry"]
for x in fruits
	print(x) # displays the fruts in the console


# Python program to group tuples by matching  
# second tuple value in list of tuples
Input = [(20, 80), (31, 80), (1, 22), (88, 11), (27, 11)] 
  
Output = {} 
for x, y in Input: 
    if y in Output: 
        Output[y].append((x, y)) 
    else: 
        Output[y] = [(x, y)] 
  
# Printing Output 
print(Output) 


# python program to illustrate If else statement   
i = 20; 
if (i < 10): 
    print ("Number is smaller than 10") 
    print ("If Block entered") 
else: 
    print ("Number is greater than 10") 
    print ("Else Block entered") 
print ("Number is not in if and not in else Block") 


# Python code to demonstrate working of in and is 
  
# using "in" to check  
if 's' in 'Telerik UI for WinForms': 
       print ("s is part of Telerik UI for WinForms") 
else : print ("s is not part of Telerik UI for WinForms") 
  
# using "in" to loop through 
for i in 'Telerik UI for WinForms': 
    print (i,end=" ") 
  
print ("\r") 
      
# using is to check object identity 
# string is immutable( cannot be changed once alloted) 
# hence occupy same memory location 
print (' ' is ' ') 
  
# using is to check object identity 
# dictionary is mutable( can be changed once alloted) 
# hence occupy different memory location 
print ({} is {}) 