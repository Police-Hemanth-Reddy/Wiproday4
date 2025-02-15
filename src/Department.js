const Department=({deptid,deptname})=>{
    return(
        <div style={{backgroundColor:'black',color:'white'}}>
        <h1>Department Details</h1>
        <h4>dept_id:{deptid}</h4>
        <h4>dept_name:{deptname}</h4>
        </div>
    )
}
export default Department;