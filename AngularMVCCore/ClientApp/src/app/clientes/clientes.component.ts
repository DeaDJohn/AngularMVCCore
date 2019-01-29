import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'clientes',
    templateUrl: 'clientes.component.html',
    styleUrls: [ 'clientes.component.css'],
    moduleId: module.id
})
export class ClientesComponent {
    private name = 'Clientes';
    public clientes: Cliente[];
    public searchText: string;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<Cliente[]>(baseUrl + 'api/Clientes/Get').subscribe(result => {
            console.log(result);
            this.clientes = result;
        }, error => console.error(error));
    }
}

interface Cliente {
  dateFormatted: string;
  Edad: number;
  nombre: string;
}
