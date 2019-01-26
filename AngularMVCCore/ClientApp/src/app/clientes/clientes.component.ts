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
  public forecasts: WeatherForecast[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'api/Clientes/WeatherForecasts').subscribe(result => {
      this.forecasts = result;
      console.log(result);
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
