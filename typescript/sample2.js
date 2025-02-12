var marks = [10, 20, 30, 40, 50];
var withbonus = marks.map(function (m) { return m + 5; }); //applying manipulation to each element in array without modifying the original one
console.log(withbonus);
console.log(marks);
var Employee = /** @class */ (function () {
    function Employee(empid, empname, salary) {
        this.empid = empid;
        this.empname = empname;
        this.salary = salary;
    }
    return Employee;
}());
;
var emps = [new Employee(1, 'hemanth', 5000),
    new Employee(2, 'arun', 6000),
    new Employee(3, 'vamshi', 3000),
    new Employee(4, 'nani', 5000),
];
var updateemp = emps.map(function (em) { return em.salary + 200; });
console.log(updateemp);
var updatedemp = emps.map(function (em) { return new Employee(em.empid, em.empname, em.salary + 200); });
console.log(updatedemp);
var updatednew = emps.filter(function (e) { return e.salary > 500; });
console.log(updatednew);
var updatedne = emps.filter(function (e) { return e.salary > 1000; })
    .map(function (e) { return new Employee(e.empid, e.empname, e.salary + 3000); });
console.log(updatedne);
var values = [10, 20, 30, 40, 50];
var resofreduce = values.reduce(function (acc, num) { return acc + num; }, 0);
console.log(resofreduce);
var totsal = emps.reduce(function (acc, emp) { return acc + emp.salary; }, 0);
console.log(totsal);
