import {Profession} from './profession';

export interface Member {
  id:           number;
  username:     string;
  gender:       string;
  created:      Date;
  lastActive:   Date;
  professionId: number;
  profession:   Profession;
}
