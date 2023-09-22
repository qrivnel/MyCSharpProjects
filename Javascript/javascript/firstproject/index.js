let word = 'javascript'
word[0] = 'y' // primitive - cannot be changed
console.log(word) 

let word2 = ['j','a','v','a', 2, 3] // nonprimitive - changeable
console.log(typeof(word2), ' ', word2)

let number1 = 5.95
console.log(Math.round(number1), typeof(number1), typeof(Math.round(number1)))
console.log(typeof(3))

let name1 = 'Erhan'
let surname1 = 'Karataş'
let fullName = name1 + ' ' + surname1
console.log(fullName)

let text = 'Lorem ipsum dolor sit amet consectetur,\ adipisicing elit.\
Iusto totam labore accusantium quod tempora,\
 neque natus veritatis eaque libero,\n quae\n minus recusandae! Repellendus\t suscipit praesentium\\ aliquam est facilis, tempore incidunt et, dolor neque provident minima nostrum perferendis temporibus alias, dignissimos nobis beatae voluptates laboriosam facere nihil aperiam. Autem, nulla commodi ducimus illo sit quae voluptates quam nisi earum molestiae ipsum natus veniam eos. Eos corrupti doloremque pariatur, id laboriosam quis.'

console.log(text)

/*
    \n : new line
    \t : tab, means 8 spaces
    \\ : back slash
    \' : single quote (')
    \" : double quote ("")
*/

let fullName2 = `${name1}
text
try
name1 length = ${name1.length}
${fullName.substr(7, 3)}
${name1 == surname1}
${surname1}`
console.log(fullName2+'\n'+fullName2[fullName2.length-1])

function plus(a, b=8){
    return a+b
}

console.log(plus(5, 9))

numberr = 3
console.log(numberr)

function arrayList(array){
    for(let i = 0; i < array.length; i++){
        console.log(array[i])
    }
}
let arr = ['E','r','h','a','n']
arr.push('')
arr.unshift('e')
arrayList(arr)
arr.pop()
arr.shift()
let arr2 = Array('1', '2')
let arr3 = []
arr2[2] = 'arr2'
arrayList(arr2)

let arr4 = arr.concat(arr2)
console.log(arr4, arr4.includes('arr2'))
let arrWord = arr4.join(' ')
console.log(arrWord)
console.log(arr4.slice(2,4))
arr4.splice(5, 4, 'K', 'a', 'r', 'a', 't', 'a', 'ş')
console.log(arr4.join(''))
console.log('!!!End of array!!!');
console.log('');

/*
      ---SCOPE---
    -> Window Scope
    -> Global Scope
    -> Local Scope
*/

const person = {
    firstName: 'Erhan',
    lastName: 'Karataş',
    age: 22,
    country: 'Turkey',
    skills: [
        'HTML',
        'CSS',
        'Java',
        'C#',
        'Javascript'
    ],
    isMarried: false,
     getFullName: function(){
         return `${this.firstName} ${this.lastName}`
     },
     getFullName2: () => `${person.firstName} ${person.lastName}`,
    'phone number': '+905433405435',
    test: {
        letTry: 'try1',
        letTry2: 'try2'
    },
    5: 'asd',
    true: 'dsa'
}
console.log(person[5], person.true);
const showAge = (person) => person['skills'][2]
console.log(showAge(person));

console.log(person.getFullName(), person.getFullName(),person["phone number"],person['age'])


let newPerson = {}
Object.assign(newPerson, person)
newPerson.firstName = 'Kemal'
console.log(newPerson.firstName);
console.log(person.firstName);

console.log(Object.keys(person));
console.log(Object.values(person));
console.log(Object.entries(person));

for(let [key, val] of Object.entries(person)){
    console.log(`${key}: ${val}`);
}

console.log(person.hasOwnProperty('firstName'));

Object.freeze(person)
person.age = 0
console.log(person.age);

// Object.seal    ==== Yeni bir şey eklenip çıkarılamaz ama varolan değerler değiştirilebilir.
console.log('This is the end of Scope and Objects!!');
console.log('');

// Higher Order Functions
console.log('--Higher Order Functions--');

const callBack = n => n ** 2
function cube(callBack, n) {
    return callBack(n) * n
}
console.log(cube(callBack, 3));

const a = n1 => {
    const b = n2 => {
        const c = n3 => {
            return n1 + n2 + n3
        }
        return c
    }
    return b
}
console.log(a(4)(9)(3));

const array = [5, 10, 15, 20]
total = 0
array.forEach((arr, index) => total += arr + index)
console.log(total);

console.log(array.reduce((oldValue, currentValue) => oldValue + currentValue, 0))

const array2 = array.map(arr => arr*2)
console.log(array2);

console.log(array.filter(arr => arr > 5 && arr < 20)  );

// setInterval
// setTimeout
function sayHello(){
    console.log('Hello!');
}
// //const interval1 = setInterval(sayHello, 1000)
// // clearInterval
// // clearTimeout

// // const timeOut1 = setTimeout(() => {
// //     clearInterval(interval1)
// // }, 3000)

// // setTimeout(() => {
// //     clearTimeout(timeOut1)
// // }, 3001)
console.log('This is the end of Higher Order Function');
console.log('');

// Set and Map
////////////////////////////////

// Destructuring, Spread and Rest
const array3 = [1, 2, 3]

const [n1, n2, n3] = array3

console.log(n1);
console.log(n2);
console.log(n3);

////////////////////////////////

//Error Handling

try {
    let a = asd
} catch (error) {
    console.log('Error: ', error);
}finally{
    console.log('trycatch is enable');
}
console.log('This is end of TryCatchFinally!!');
console.log('');

//Classes
class Person{
    constructor(name, surname, age){
        this.name = name
        this.surname = surname
        this.age = age
    }
}

let person1 = new Person('Erhan', 'Karataş', 22)
console.log(person1);

class Student extends Person{
    constructor(name, surname, age, gender) {
        super(name, surname, age)
        this.gender = gender
    }

    static learn() {
        console.log('Learn');
    }

    get getGender() {
        return this.gender == 1 ? 'Erkek' : 'Kadın'
    }
}

Student.learn();

const student = new Student('Erhan', 'Karataş', 22, 1)
console.log(student.getGender);

