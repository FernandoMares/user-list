import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserListComponent } from './components/user-list-component/user-list-component.component';  // Importa el componente

const routes: Routes = [
  { path: '', component: UserListComponent },  // Ruta para cargar UserListComponent como la página principal
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
