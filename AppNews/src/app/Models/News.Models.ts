import { Author } from './autor.models';

export interface news{
    Idnews: number;
    Title: string;
    Descrip: string;
    Fecha: Date;
    Content: string;
    Idauthor: number;
    Author: string;
    autor: Author;

}