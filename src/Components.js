import './style.css';
export const Employees=({name,id})=>{
    return(
        <div className="container">
            <h1>Employee Details:</h1>
            <h4>Name:{name}</h4>
            <h4>id:{id}</h4>
        </div>
    )
}
export const Departments=({deptid,deptname})=>{
    return (
        <div className="container">
            <h1>Department Details:</h1>
            <h4>id:{deptid}</h4>
            <h4>name:{deptname}</h4>
        </div>
    )
}
