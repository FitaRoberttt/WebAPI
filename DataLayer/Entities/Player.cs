﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Entities;


public class Player
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; }
    public List<Stats> Stats { get; set; }
    public string Position { get; set; }



}
