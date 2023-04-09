import { Component, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SearchService } from './search-service.service';
import { IViolationBase } from './models/violationBase';
import { Observable, delay, mergeMap, take } from 'rxjs';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [ SearchService ]
})
export class AppComponent {
  title = 'RiskSolutionApp';
  isLoading = false;

  ViolationTypesList = [
    {
      text:'Одне зі списку',
      value: null
    },
    {
      text:'Конфіденційності',
      value: 'con'
    },
    {
      text:'Доступності',
      value: 'acc',
    },
    {
      text:'Цілісності',
      value: 'int'
    }
  ];
  FieldsList = [
    {
      text: 'Всі',
      value: null
    },
    {
      text: 'Загроза',
      value: 'Threat'
    },
    {
      text: 'Джерело загрози',
      value: 'SourceOfThreat'
    },
    {
      text: 'Механізм реалізації нападу',
      value: 'AttackImplementation'
    }
  ];

  formGroup: FormGroup;

  query?: Observable<IViolationBase[]>;
  result: IViolationBase[] | null;

  constructor(private readonly formbuilder: FormBuilder, private readonly searchService: SearchService, private modalService: NgbModal) {
    this.formGroup = this.formbuilder.group({
      ViolationTypeChosen: [, Validators.required],
      field: [,],
      value: [,Validators.required]
    });
    this.result = null;
  }

  public Search(modal: any): void {
    let table = this.formGroup.get('ViolationTypeChosen')?.value;
    let field = this.formGroup.get('field')?.value;
    if (!table || !table.length) {
      this.modalService.open(modal);
      return;
    }

    this.isLoading = true;
    if(field == 'null')
      field = null
    let value = this.formGroup.get('value')?.value;
    switch(table) {
      case 'con':
        this.query = this.searchService.SearchConfidentialityViolation(field, value).pipe(delay(1500), take(1));
        this.query.subscribe((val) => { this.isLoading = false; this.result = val; console.log(this.result); }, (err) => this.isLoading = false)
        console.log(this.result);
        break;
      case 'acc':
        this.query = this.searchService.SearchAccessibilityViolation(field, value).pipe(delay(1500), take(1));
        this.query.subscribe((val) => { this.isLoading = false; this.result = val; console.log(this.result); }, (err) => this.isLoading = false)
        console.log(this.result);
        break;
      case 'int':
        this.query = this.searchService.SearchIntegrityViolation(field, value).pipe(delay(1500), take(1));
        this.query.subscribe((val) => { this.isLoading = false; this.result = val; console.log(this.result); }, (err) => this.isLoading = false)
        break;
      default:
        break;
    }
  }
}
