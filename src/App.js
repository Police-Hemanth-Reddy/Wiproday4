
import './App.css';
import Welcome from './Welcome';
import Employee from'./Employee';
import {Departments,Employees} from'./Components';
import Category from'./Category';
import Product from './Product';
function App() {
  return (
    <>
   <Welcome></Welcome>
   <Employee name="hemanth" sal="5000" deptid="22" deptname="ECE"></Employee>
   <Employees name="hemanth" id="5000"></Employees>
   <Departments deptid="1" deptname="IT"></Departments>
    <Product Pname="mobile" Cname="electronics"></Product>
    <Category Cname="cloths"></Category>
   </>
  );
}

export default App;
