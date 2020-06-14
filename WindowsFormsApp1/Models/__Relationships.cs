using Micron;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{

#region FIRES
 public partial class Fire
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  User GetUser() { return DefaultDBContext.GetRecord<User>(this.user_id); }
   public void SetUser(User model)  {  DefaultDBContext.SetRelation(this, model);}


 }
#endregion
#region ROLES
 public partial class Role
 {
public MicronDbContext DefaultDBContext { get; set; }

   public bool HasUsers(string where="true") {return DefaultDBContext.GetRecords<User>("role_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<User> GetUsers(string where="true") {return DefaultDBContext.GetRecords<User>("role_id = "+this.id+" AND "+where);}
    public void AddUser(User model) { model.SetRole(this); }
    public void AddUsers(IEnumerable<User> models) {foreach(var model in models) model.SetRole(this); }

 }
#endregion
#region USERS
 public partial class User
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Role GetRole() { return DefaultDBContext.GetRecord<Role>(this.role_id); }
   public void SetRole(Role model)  {  DefaultDBContext.SetRelation(this, model);}

   public bool HasFires(string where="true") {return DefaultDBContext.GetRecords<Fire>("user_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Fire> GetFires(string where="true") {return DefaultDBContext.GetRecords<Fire>("user_id = "+this.id+" AND "+where);}
    public void AddFire(Fire model) { model.SetUser(this); }
    public void AddFires(IEnumerable<Fire> models) {foreach(var model in models) model.SetUser(this); }

 }
#endregion

}
