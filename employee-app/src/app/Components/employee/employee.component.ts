import { Component, ElementRef, OnInit, ViewChild, viewChild } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-employee',
  imports: [ReactiveFormsModule],
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css'
})
export class EmployeeComponent implements OnInit {
@ViewChild('myModal') modal : ElementRef | undefined;

 employeeForm : FormGroup = new FormGroup({});
 constructor(private fb:FormBuilder){}

ngOnInit(): void 
{
  this.setFormState();
}


  openModal()
  {
    const empModal = document.getElementById('myModal');
    if(empModal !=null)
    {
      empModal.style.display='block';
    }


  }

  closeModal()
  {
    if(this.modal !=null)
    {
      this.modal.nativeElement.style.display='none';
    }
  }

setFormState()
{
  this.employeeForm = this.fb.group({
    id: [0],
    nameX:['',[Validators.required]],
    emailX: ['',[Validators.required]],
    mobileX: ['',[Validators.required]],
    ageX: ['',[Validators.required]],
    salaryX: ['',[Validators.required]],
    statusX: [false,[Validators.required]]
  });
}

onSubmit()
{
 console.log(this.employeeForm.value);
}


}
