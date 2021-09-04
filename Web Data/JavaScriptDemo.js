//alert("this is an alert")
let response = prompt("this is a prompt", "this is the default");
console.log(`${response}`);

//declaring variables we use: let, const or var
let something = "whatever you want ";
console.log(`${something}`);

const constVar = 200;
console.log(`${constVar}`);
constVar = 2000;
console.log(`${constVar}`);

var varVar = "My var is a var, var";
console.log(`$varVar`);

let guy = "mark", age = 42, address = "123 Main St.";
console.log(`${guy} is ${age} and lives at ${address}`);


//cannot start a variables with a #
//variables are case sentative
//there is also some keywords that you cannot use so be mindful, link inside the pdf

//demonstrating it being dynamically typed

guy = 42;
age = "Mark"
console.log(`${guy} is ${age} and lives at ${address}`);



//scope-defined by curly braces
//example below will give an error 
//you can declare a scope form anywhere but anything declared insode the scope is available only inside the scope
// {
//   let scoped1 ="this is a scope";
// }console.log(scoped1)



//there are 16 primitive data types 
//Javascript is a weekly typed language unlike c and the other programming language. this mean I cam change the tye of the variable 
let mybright = 1234567894444444444444444444444444444444444444444444n; //bright
let mystring = "Davian 'quote' is here ", myString1 = 'myOtherString'; //string
console.log(`"The 5th char is =>" ${myString[5]}`);

let myBool = true;//boolean
console.log(myBool);
myBool = "Mark";
console.log(myBool);

//number
let myNumber = 1234.6542;
let myNumber1 = 101;
console.log(`${myNumber} and ${myNumber1} are valid as Number type`);


//null datatype
let markswallet = null;
console.log(`${marksWallet}`);


//undefined data type
let x;
console.log(`${x}`);

//creatign Objects
let marksObject = { name: "Mark", age: 42, strength: "weaker everyday" };
console.log(`${marksObject.name} is now ${marksObject.age} and is ${marksObject.strength}`);

console.log(typeof (marksObject));
console.log(typeof myString);

console.log(5 + 5);
console.log(5 * 5);
console.log(5 / 5);
console.log(5 - 5);
console.log(5 ** 2);
console.log(10 / (3 + 2) * 4 + 5 ** 2 + (6 - 9)); //answer 30

//demonstrating that javascript is loosely typed 
console.log(marksObject.name + '' + (5 + 5));



console.log(5 - 5 + 110)//115
let oneten = 110;
console.log(5 - 5 + oneten++)
console.log(oneten);


//whats the diff btwn =,==,===
//= is assignment 
//==performs types coersion, TC is testing differenct types() number, bigint, string, etc) to see if there
// is any wa that the types difference can be reconciled.

let myNum5 = '5';
let myNum6 = 5;
console.log(myNum5 == myNum6);
console.log(myNum5 === myNum6);


//truthy falsy
let false1 = false;
if (!false1) {
  console.log("it was false")
}
else {
  console.log("it was true");
}

let nullVal = null;

if (!nullVal) {
  console.log("it was false")
}
else {
  console.log("it was true");
}


let zeroVal = null

if (!zeroVal) {
  console.log("it was false")
}
else {
  console.log("it was true");
}


if (!"") {
  console.log("it was false")
}
else {
  console.log("it was true");
}



let undef;
console.log(Number(undef));//comes out as NaN



console.log(Math.random() * 10);
console.log()


let marksObject = { name: "Mark", age: 42, strength: "weaker everyday" };
console.log(o)