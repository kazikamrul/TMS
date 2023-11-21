import { SelectionModel } from '@angular/cdk/collections';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { CourseModule } from '../../models/CourseModule';
import { CourseModuleService } from '../../service/CourseModule.service';
import { ConfirmService } from 'src/app/core/service/confirm.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MasterData } from 'src/assets/data/master-data';
import { MatSnackBar } from '@angular/material/snack-bar';


@Component({
  selector: 'app-coursemodule-list',
  templateUrl: './coursemodule-list.component.html',
  styleUrls: ['./coursemodule-list.component.sass']
})
export class CourseModuleListComponent implements OnInit {

   masterData = MasterData;
  loading = false;
  ELEMENT_DATA: CourseModule[] = [];
  isLoading = false;

  paging = {
    pageIndex: this.masterData.paging.pageIndex,
    pageSize: this.masterData.paging.pageSize,
    length: 1
  }
  searchText="";

  displayedColumns: string[] = [ 'sl',/*'courseModuleId',*/ 'baseSchoolName', 'courseName', 'moduleName','nameOfModule', /*'menuPosition',*/ 'actions'];
  dataSource: MatTableDataSource<CourseModule> = new MatTableDataSource();

  selection = new SelectionModel<CourseModule>(true, []);

  
  constructor(private route: ActivatedRoute,private snackBar: MatSnackBar,private CourseModuleService: CourseModuleService,private router: Router,private confirmService: ConfirmService) { }
  
  ngOnInit() {
    this.getCourseModules();
  }
  
  getCourseModules() {
    this.isLoading = true;
    this.CourseModuleService.getCourseModules(this.paging.pageIndex, this.paging.pageSize,this.searchText).subscribe(response => {
     

      this.dataSource.data = response.items; 
      this.paging.length = response.totalItemsCount    
      this.isLoading = false;
    })
  }
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.filteredData.length;
    return numSelected === numRows;
  }

  masterToggle() {
    this.isAllSelected()
      ? this.selection.clear()
      : this.dataSource.filteredData.forEach((row) =>
          this.selection.select(row)
        );
  }
  addNew(){
    
  }
 
  pageChanged(event: PageEvent) {
    this.paging.pageIndex = event.pageIndex
    this.paging.pageSize = event.pageSize
    this.paging.pageIndex = this.paging.pageIndex + 1
    this.getCourseModules();
  }

  applyFilter(searchText: any){ 
    this.searchText = searchText;
    this.getCourseModules();
  } 


  deleteItem(row) {
    const id = row.courseModuleId; 
    this.confirmService.confirm('Confirm delete message', 'Are You Sure Delete This Course Module Item?').subscribe(result => {
      console.log(result);
      if (result) {
        this.CourseModuleService.delete(id).subscribe(() => {
          this.getCourseModules();
          this.snackBar.open('Information Deleted Successfully ', '', {
            duration: 3000,
            verticalPosition: 'bottom',
            horizontalPosition: 'right',
            panelClass: 'snackbar-danger'
          });
        })
      }
    })
    
  }
}