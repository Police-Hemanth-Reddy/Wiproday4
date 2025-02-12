let msg="Welcome"
console.log(msg);
interface Employee{
    id?:number,
    name:string,
    dept:string
}
function getEmployee(emp:Employee){
    return `${emp.id} ${emp.name} ${emp.dept}`;
}
let emp1={
    id:1,
    name:"hemanth",
    dept:"it"
}
console.log(getEmployee(emp1));
function getDestructor({name,dept}:Employee){
    return `${name} ${dept}`;
}
let emp2={
    name:'hemanth',
    dept:'it'
}
console.log(getDestructor(emp2));
function sum(a:number,b:number):number{
    return a+b;
}
let res=sum(1,2);
console.log(res);
//inferring function=where a functionn is direclty assigned to variable without fun nname
let result=function(a:number,b:number):number{
    return a+b;
}
console.log(result(10,20));
//default parameter is used if value is not assigned at method call
function product(x:number=10,y?:number):number{//here x can be set as default
    if(typeof y!=='undefined'){
        return x*y;
    }
    return x*x;
}
console.log(product(1,2));
console.log(product(10));
console.log(product());
//...numbers(any variable) indicates that is an array of any size
function sumof(...numbers:number[]):number{
    let total=0;
    numbers.forEach(num=>total+=num);
    return total;
}
console.log(sumof(1,23,4,5,));
console.log(sumof(2,3,4));