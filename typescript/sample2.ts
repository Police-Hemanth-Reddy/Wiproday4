
const marks: number[] = [10,20,30,40,50];

const withbonus = marks.map(m => m+5); //applying manipulation to each element in array without modifying the original one

console.log(withbonus);
console.log(marks);


class Employee{
    empid:number;
    empname:string;
    salary:number;
   constructor(empid:number,empname:string,salary:number)
   {
    this.empid=empid;
     this.empname = empname;
     this.salary = salary;
   }
};

let emps : Employee[] = [new Employee(1,'hemanth',5000),
    new Employee(2,'arun',6000),
    new Employee(3,'vamshi',3000),
    new Employee(4,'nani',5000),
]

let updateemp =emps.map(em =>em.salary + 200);
console.log(updateemp);


let updatedemp =emps.map(em =>new Employee(em.empid,em.empname,em.salary + 200));
console.log(updatedemp);


let updatednew =emps.filter(e=>e.salary>500);
console.log(updatednew);

let updatedne =emps.filter(e=>e.salary>1000)
                .map(e => new Employee(e.empid,e.empname,e.salary +3000));
console.log(updatedne);


let values = [10,20,30,40,50];
let resofreduce = values.reduce((acc,num) => acc+num,0);
console.log(resofreduce);


const totsal = emps.reduce((acc,emp)=>acc+emp.salary,0)
console.log(totsal);