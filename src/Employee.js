import Department from'./Department';
const Employee=({name,sal,deptid,deptname})=>{
    return(
        <div>
            <h1>Employee details</h1>
            <h4>Name:{name}</h4>
            <h4>sal:{sal}</h4>
            <h1>Department details</h1>
            <h4>Dept_id:{deptid}</h4>
            <h4>Dept_Name:{deptname}</h4>
        </div>
    )
}
export default Employee;