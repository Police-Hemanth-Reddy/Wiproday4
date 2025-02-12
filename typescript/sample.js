var msg = "Welcome";
console.log(msg);
function getEmployee(emp) {
    return "".concat(emp.id, " ").concat(emp.name, " ").concat(emp.dept);
}
var emp1 = {
    id: 1,
    name: "hemanth",
    dept: "it"
};
console.log(getEmployee(emp1));
function getDestructor(_a) {
    var name = _a.name, dept = _a.dept;
    return "".concat(name, " ").concat(dept);
}
var emp2 = {
    name: 'hemanth',
    dept: 'it'
};
console.log(getDestructor(emp2));
function sum(a, b) {
    return a + b;
}
var res = sum(1, 2);
console.log(res);
//inferring function=where a functionn is direclty assigned to variable without fun nname
var result = function (a, b) {
    return a + b;
};
console.log(result(10, 20));
//default parameter is used if value is not assigned at method call
function product(x, y) {
    if (x === void 0) { x = 10; }
    if (typeof y !== 'undefined') {
        return x * y;
    }
    return x * x;
}
console.log(product(1, 2));
console.log(product(10));
console.log(product());
//...numbers(any variable) indicates that is an array of any size
function sumof() {
    var numbers = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        numbers[_i] = arguments[_i];
    }
    var total = 0;
    numbers.forEach(function (num) { return total += num; });
    return total;
}
console.log(sumof(1, 23, 4, 5));
console.log(sumof(2, 3, 4));
