console.log("Hey there Davian")

//using a function in JS

//function declaration (called a method in c#)
function myfunc1(x, y = 'this is a default value') {
  return `I have ${x} values  called ${y}.`
}

console.log(myfunc1(3, 4));

//function expression--done differently than above 
let myfunc2 = function (x, y) {
  return x + y;
}

//calling the function
console.log(myfunc2(4, 5));



//both are referencing the same spot in memory here 
let myfunc3 = myfunc2;


console.log(myfunc2(1, 2));
console.log(myfunc3(10, 12));



//both are doing the same thing
//if your arrow function body needs more than one line, then you must use {}
let myfunc4 = (x, y) => x + y;  //this is the same as the function was below this arrow function is just more concise 

let myfunc5 = function (x, y) {
  return x + y;
}



console.log(myfunc4(9, 10));
console.log(myfunc5(9, 10));



//example of using the arrow function with {}
let myfunc6 = () => {
  console.log(`this is a multiline arrow function`)
  console.log(`it uses more than one lone in the body of the function`)
}
myfunc6();


//////////////////////////////////////////////////////////////////////////recheck here from marks document ////////////////////////////////////////////////////////////////////////////

function callback1(param1) {

  return `this value is EVEN ${param1}`;

}

function callback2(callback2param1) {

  console.log(`this value is ODD ${param1}`);

}





//this arrow function will evaluate the x if it is a number and even then callback function y will be envoked
//if not, then z will be invoked 
let myfunc7 = (x, y, z) => {
  if (x % 2 === 0) {
    console.log(y(x));
  }
  else {
    console.log(z(x));
  }
}
//this is taking the arguments from the custion listed witht he if statement above
myfunc7(1, callback1, callback2);

//another way to call the same function
myfunc7(
  1,
  (param1) => `This value is Even...${param1}`,
  (param1) => `This value is ODD...${param1}`
);


//other method to declare and call the function one place

(function (
  x = 1,
  y = (param1) => `This value is Even...${param1}`,
  z = (param1) => `This value is ODD...${param1}`
) {


  if (x % 2 === 0) {
    console.log(y(x));
  }
  else {
    console.log(z(x));
  }
})();



//calling a function and return another function
function makeadder(x) {
  return () => {
    return x + y;
  }
}

let makeadderholder = makeadder(10);
console.log(makeadder(5));
//this above will print 15 adding the 10 to 5



function concatSentences(x) {
  console.log(`The first call was with "${x}"`)
  return (y) => {
    console.log(`The second call was with "${y}"`)
    return x + '' + y;
  }
}


let concatInnerFunction = concatSentences('Marks computer')
console.log(concatInnerFunction);
console.log(concatInnerFunction('is really hot right now'));




///////////////////////////////////////go over here form marks documents///////////////////////
try {

}
catch (err) {
  console.log(`err.name is "${err.name}"`);
  console.log(`err.stack is "${err.stack}"`);
  console.log(`err.name is "${err.name}"`);
}