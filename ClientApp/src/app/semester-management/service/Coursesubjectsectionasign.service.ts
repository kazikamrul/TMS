import { Injectable } from '@angular/core';


import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from '../../../environments/environment' 
import { ITraineeNominationPagination,TraineeNominationPagination } from '../models/traineenominationPagination';
import { TraineeNomination } from '../models/traineenomination';
import { SelectedModel } from '../../core/models/selectedModel';
import { map } from 'rxjs';
import { PostResponse } from '../../../app/core/models/PostResponse';
import { TraineeList} from '../../attendance-management/models/traineeList'


@Injectable({
  providedIn: 'root'
})


export class CoursesubjectsectionasignService {
  baseUrl = environment.apiUrl;
  //TraineeNominations: TraineeNomination[] = [];
  //TraineeNominationPagination = new TraineeNominationPagination(); 
  constructor(private http: HttpClient) { }

/*

  find(id: any) {
    return this.http.get<TraineeNomination>(this.baseUrl + '/trainee-nomination/get-traineeNominationDetail/' + id);
  }
  update(id: number,model: any) {
    return this.http.put(this.baseUrl + '/trainee-nomination/update-traineeNomination/'+id, model);
  }
  
  submit(model: any) {
    return this.http.post<PostResponse>(this.baseUrl + '/trainee-nomination/save-traineeNomination', model).pipe(
      map((TraineeNomination: PostResponse) => {
        if (TraineeNomination) {
          console.log(TraineeNomination);
          return TraineeNomination;
        }
      })
    );
  } 
  delete(id:number){
    return this.http.delete(this.baseUrl + '/trainee-nomination/delete-traineeNomination/'+id);
  }
  */
}
