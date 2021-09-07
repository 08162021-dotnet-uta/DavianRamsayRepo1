//ways of creating a class in JS

let class1 = new Object(); //object constructor syntax
let class2 = {}  // object literal syntax


class2.name = 'Mark';
console.log(class2.name)

//yu can have objects inside objects and classes
class2.myObject = {
  fname: 'Joe',
  lname: 'Dimaggio'
}

class2.myFunc = () => `This is the internal function ${class2.fname}`

console.log(`${class2.myFunc()}`)


console.log(`The greatest husband ever was ${class2.myObject.fname} ${class2.myObject.lname}`)

function baseballPlayer(battingAvg, fname, lname, team) {
  return {
    battingAvg: battingAvg,
    fname: fname,
    lname: lname,
    team: team
  }
}

let joeyD = baseballPlayer(.300, 'Joe', 'Dimaggio', 'Yankees');
let NolanR = baseballPlayer(.050, 'Nolan', 'Ryan', 'Rangers');

console.log(`My two fav bb players are ${joeyD.fname} ${joeyD.lname} and ${NolanR.fname} and ${NolanR.lname}`)





//expressions
// let class3 = {
//   name,
//   age
// }
// class3.name = 'Mark';
// class3.age = 42;


// console.log(`${class3.name}`)



//the "in" keyword is asking if battingAvg exist in baseballPlayer function

console.log('battingAvg' in baseballPlayer())


//should print out true but is showing false ---recheck
console.log('fname' in class2)


//using for loops 
for (let x in class2) {
  console.log(x);
}


//create actual classes in JS
class MyBirdClass3 {
  constructor(type, region) {
    this.type = type;
    this.region = region;
  }

  PrintDeets() {
    return `This bird is from ${this.region} and its a ${this.type}`
  }

  set SetRegion(x) {
    if (x.length > 20) {
      return;

    }
    else {
      this.region = x;
      return;
    }


  }

  set SetType(y) {
    this.type = y;

  }

}

let myFirstBird = new MyBirdClass3('swallow', 'Africa')
//console.log(`The bird is ${myFirstBird.type} and comes from ${myFirstBird.region}`);

console.log(myFirstBird.PrintDeets())




/////////////////////////recheck this console log below//////////////////////////////////////////////

console.log(myFirstBird.SetRegion = 'America', 'the new value is ${myFirstBird.region}')



//implementing inheritance
class MyFalconClass extends MyBirdClass3 {
  constructor(type, region, numToes, lifeSpan) {
    super(type, region) ////when you extends a class you must use Super to call the main constructor from that class
    this.numToes = numToes;
    this.lifeSpan = lifeSpan;
  }
}

let myFalcon = new MyFalconClass('Falcon', '\'Merca', 3, 10)

console.log(`This Falcon is a ${myFalcon.type} she's from ${myFalcon.region}, has ${myFalcon.numToes} for ${myFalcon.lifeSpan}`)