  
import { Injectable } from '@angular/core';

export const DEFAULT_CONFIG = {
   baseUrl : 'http://localhost:5000/api/user/'
}

export const USER_CONFIG ={
    registerUrl : DEFAULT_CONFIG.baseUrl + 'register'

}