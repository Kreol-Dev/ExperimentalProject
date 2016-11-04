namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="conflict_decomposition", OncePerObject=true, OncePerTurn=false)]
    public class war_conflict : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1 = default(System.Boolean); //IsContext = False IsNew = False
			Conflict StoredVariable0 = ((Conflict)root.GetComponent(typeof(Conflict))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				applicable = true;
				OperandVar1 = applicable;
			}
			return (System.Boolean) (OperandVar1);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject first = new UnityEngine.GameObject("first"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject first2 = first; //IsContext = True IsNew = False
				Entity AddContext3 = (Entity)first.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.foe_role AddContext4 = (Blackboards.foe_role)first.AddComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = True
				Actor AddContext5 = (Actor)first.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(first);
			UnityEngine.GameObject second = new UnityEngine.GameObject("second"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject second6 = second; //IsContext = True IsNew = False
				Entity AddContext7 = (Entity)second.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Actor AddContext8 = (Actor)second.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.foe_role AddContext9 = (Blackboards.foe_role)second.AddComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.foe_role AddContext9 ContextSwitchInterpreter
					if(AddContext9 != null)
					{
						UnityEngine.GameObject OperandVar10 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar10 = first;
						AddContext9.Enemy = (UnityEngine.GameObject)( (OperandVar10));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(second);
			
			{
				UnityEngine.GameObject subContext11 = first; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext11 ContextPropertySwitchInterpreter
				if(subContext11 != null)
				{
					
					{
						Blackboards.foe_role subContext12 = (Blackboards.foe_role)subContext11.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
						//ContextStatement Blackboards.foe_role subContext12 ContextSwitchInterpreter
						if(subContext12 != null)
						{
							UnityEngine.GameObject OperandVar13 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar13 = second;
							subContext12.Enemy = (UnityEngine.GameObject)( (OperandVar13));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="foe_decomposition", OncePerObject=true, OncePerTurn=false)]
    public class foe_is_ruler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar15 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable14 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable14 != null)
			{
				applicable = true;
				OperandVar15 = applicable;
			}
			return (System.Boolean) (OperandVar15);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Blackboards.ruler_role ContextVar16 = root.AddComponent<Blackboards.ruler_role>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.ruler_role ContextVar16 ContextSwitchInterpreter
				if(ContextVar16 != null)
				{
					System.Single OperandVar18 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop17 = External.Random( (10f), (20f)); //IsContext = False IsNew = False
					OperandVar18 = prop17;
					ContextVar16.Forces = (System.Single)( (OperandVar18));
					
					ContextVar16.People = (System.Single)( (1f));
				}
			}
			Entity EntVar19 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar19 != null) EntVar19.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true)]
    public class ruler_vs_ruler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar29 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable20 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable20 != null)
			{
				Blackboards.foe_role StoredVariable21 = ((Blackboards.foe_role)StoredVariable20.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
				if(StoredVariable21 != null)
				{
					Blackboards.ruler_role StoredVariable22 = ((Blackboards.ruler_role)StoredVariable21.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable22 != null)
					{
						System.Boolean ifResult23; //IsContext = False IsNew = False
						
						System.Boolean OperandVar26 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable21 != null)
						{
							UnityEngine.GameObject prop24 = StoredVariable21.Enemy; //IsContext = False IsNew = False
							if(prop24 != null)
							{
								Blackboards.ruler_role StoredVariable25 = ((Blackboards.ruler_role)prop24.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable25 != null)
								{
									applicable = true;
									OperandVar26 = applicable;
								}
							}
						}
						
						System.Boolean OperandVar28 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable20 != null)
						{
							System.Boolean prop27 = StoredVariable20.IsActive; //IsContext = False IsNew = False
							OperandVar28 = prop27;
						}
						if(ifResult23 = ( ( (OperandVar26))) && ( (!(OperandVar28))))
						{
							applicable = true;
							OperandVar29 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar29);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.Single OperandVar32 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable30 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable30 != null)
			{
				System.Single prop31 = StoredVariable30.Forces; //IsContext = False IsNew = False
				OperandVar32 = prop31;
			}
			System.Single my_forces =  (OperandVar32); //IsContext = False IsNew = False
			System.Single OperandVar37 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable33 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable33 != null)
			{
				UnityEngine.GameObject prop34 = StoredVariable33.Enemy; //IsContext = False IsNew = False
				if(prop34 != null)
				{
					Blackboards.ruler_role StoredVariable35 = ((Blackboards.ruler_role)prop34.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable35 != null)
					{
						System.Single prop36 = StoredVariable35.Forces; //IsContext = False IsNew = False
						OperandVar37 = prop36;
					}
				}
			}
			System.Single enemy_forces =  (OperandVar37); //IsContext = False IsNew = False
			
			{
				Blackboards.foe_role subContext38 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext38 ContextSwitchInterpreter
				if(subContext38 != null)
				{
					
					
					System.Single OperandVar39 = default(System.Single); //IsContext = False IsNew = False
					OperandVar39 = my_forces;
					
					
					if(!(( ( (OperandVar39))) == ( ( (0f)))))
					{
						System.Single OperandVar40 = default(System.Single); //IsContext = False IsNew = False
						OperandVar40 = enemy_forces;
						System.Single OperandVar41 = default(System.Single); //IsContext = False IsNew = False
						OperandVar41 = my_forces;
						subContext38.ThreatLevel = (System.Single)(( (OperandVar40)) / ( (OperandVar41)));
					}
					
					
					System.Single OperandVar42 = default(System.Single); //IsContext = False IsNew = False
					OperandVar42 = my_forces;
					
					
					
					
					System.Single OperandVar44 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop43 = subContext38.ThreatLevel; //IsContext = False IsNew = False
					OperandVar44 = prop43;
					
					
					if(( (( ( (OperandVar42))) == ( ( (0f))))) || ( (( ( (OperandVar44))) > ( ( (1000f))))))
					{
						
						subContext38.ThreatLevel = (System.Single)( (1000f));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class start_a_war : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar64 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable45 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable45 != null)
			{
				Blackboards.foe_role StoredVariable46 = ((Blackboards.foe_role)StoredVariable45.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
				if(StoredVariable46 != null)
				{
					Blackboards.ruler_role StoredVariable47 = ((Blackboards.ruler_role)StoredVariable46.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable47 != null)
					{
						System.Boolean ifResult48; //IsContext = False IsNew = False
						
						System.Boolean OperandVar55 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable46 != null)
						{
							UnityEngine.GameObject prop49 = StoredVariable46.Enemy; //IsContext = False IsNew = False
							if(prop49 != null)
							{
								System.Boolean ifResult50; //IsContext = False IsNew = False
								System.Boolean OperandVar54 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.ruler_role OperandVar52 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
								Blackboards.ruler_role StoredVariable51 = ((Blackboards.ruler_role)prop49.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable51 != null)
								{
									OperandVar52 = StoredVariable51;
								}
								System.Boolean prop53 = External.Has( (OperandVar52)); //IsContext = False IsNew = False
								OperandVar54 = prop53;
								if(ifResult50 =  (OperandVar54))
								{
									OperandVar55 = ifResult50;
								}
							}
						}
						
						System.Boolean OperandVar61 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar57 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> prop56 = StoredVariable47.AtWarWith; //IsContext = False IsNew = False
						if(prop56 != null)
						{
							OperandVar57 = prop56;
						}
						UnityEngine.GameObject OperandVar59 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable46 != null)
						{
							UnityEngine.GameObject prop58 = StoredVariable46.Enemy; //IsContext = False IsNew = False
							if(prop58 != null)
							{
								OperandVar59 = prop58;
							}
						}
						System.Boolean prop60 = External.Contains( (OperandVar57), (OperandVar59)); //IsContext = False IsNew = False
						OperandVar61 = prop60;
						
						System.Boolean OperandVar63 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable45 != null)
						{
							System.Boolean prop62 = StoredVariable45.IsActive; //IsContext = False IsNew = False
							OperandVar63 = prop62;
						}
						if(ifResult48 = ( ( (OperandVar55))) && ( (!(OperandVar61))) && ( ( (OperandVar63))))
						{
							applicable = true;
							OperandVar64 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar64);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.foe_role subContext65 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext65 ContextSwitchInterpreter
				if(subContext65 != null)
				{
					
					{
						Blackboards.ruler_role subContext66 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
						//ContextStatement Blackboards.ruler_role subContext66 ContextSwitchInterpreter
						if(subContext66 != null)
						{
							UnityEngine.GameObject OperandVar68 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							if(subContext65 != null)
							{
								UnityEngine.GameObject prop67 = subContext65.Enemy; //IsContext = False IsNew = False
								if(prop67 != null)
								{
									OperandVar68 = prop67;
								}
							}
							subContext66.AtWarWith.Add( (OperandVar68));
						}
					}
					
					{
						UnityEngine.GameObject subContext69 = subContext65.Enemy; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext69 ContextPropertySwitchInterpreter
						if(subContext69 != null)
						{
							
							{
								Blackboards.ruler_role subContext70 = (Blackboards.ruler_role)subContext69.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext70 ContextSwitchInterpreter
								if(subContext70 != null)
								{
									UnityEngine.GameObject OperandVar71 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar71 = root;
									subContext70.AtWarWith.Add( (OperandVar71));
								}
							}
						}
					}
				}
			}
			UnityEngine.GameObject event_war_declaration = new UnityEngine.GameObject("event_war_declaration"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject event_war_declaration72 = event_war_declaration; //IsContext = True IsNew = False
				Event AddContext73 = (Event)event_war_declaration.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext73 ContextSwitchInterpreter
					if(AddContext73 != null)
					{
						UnityEngine.GameObject OperandVar74 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar74 = root;
						AddContext73.Context = (UnityEngine.GameObject)( (OperandVar74));
					}
				}
				Blackboards.war_declaration AddContext75 = (Blackboards.war_declaration)event_war_declaration.AddComponent(typeof(Blackboards.war_declaration)); //IsContext = True IsNew = True
				Blackboards.targeted_event AddContext76 = (Blackboards.targeted_event)event_war_declaration.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext76 ContextSwitchInterpreter
					if(AddContext76 != null)
					{
						UnityEngine.GameObject OperandVar79 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.foe_role StoredVariable77 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
						if(StoredVariable77 != null)
						{
							UnityEngine.GameObject prop78 = StoredVariable77.Enemy; //IsContext = False IsNew = False
							if(prop78 != null)
							{
								OperandVar79 = prop78;
							}
						}
						AddContext76.Target = (UnityEngine.GameObject)( (OperandVar79));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(event_war_declaration);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class gather_reinforcements : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar86 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable80 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable80 != null)
			{
				Blackboards.foe_role StoredVariable81 = ((Blackboards.foe_role)StoredVariable80.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
				if(StoredVariable81 != null)
				{
					Blackboards.ruler_role StoredVariable82 = ((Blackboards.ruler_role)StoredVariable81.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable82 != null)
					{
						System.Boolean ifResult83; //IsContext = False IsNew = False
						System.Boolean OperandVar85 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable80 != null)
						{
							System.Boolean prop84 = StoredVariable80.IsActive; //IsContext = False IsNew = False
							OperandVar85 = prop84;
						}
						if(ifResult83 =  (OperandVar85))
						{
							applicable = true;
							OperandVar86 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar86);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar89 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable87 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable87 != null)
			{
				System.Single prop88 = StoredVariable87.People; //IsContext = False IsNew = False
				OperandVar89 = prop88;
			}
			
			
			return (System.Single)( ( (OperandVar89))) - ( ( (0.3f)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject act = new UnityEngine.GameObject("act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject act90 = act; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext91 = (Blackboards.notify_event)act.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext91 ContextSwitchInterpreter
					if(AddContext91 != null)
					{
						UnityEngine.GameObject OperandVar92 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar92 = root;
						AddContext91.Who = (UnityEngine.GameObject)( (OperandVar92));
						
						AddContext91.Data = (System.String)( ("gather_reinforcements"));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(act);
			
			{
				Blackboards.ruler_role subContext93 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext93 ContextSwitchInterpreter
				if(subContext93 != null)
				{
					
					System.Single OperandVar95 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop94 = subContext93.Forces; //IsContext = False IsNew = False
					OperandVar95 = prop94;
					
					
					subContext93.Forces = (System.Single)(( ( (OperandVar95))) + ( ( (7f))));
					
					System.Single OperandVar97 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop96 = subContext93.People; //IsContext = False IsNew = False
					OperandVar97 = prop96;
					
					
					subContext93.People = (System.Single)(( ( (OperandVar97))) - ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true)]
    public class growth : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar105 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable98 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable98 != null)
			{
				Blackboards.ruler_role StoredVariable99 = ((Blackboards.ruler_role)StoredVariable98.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable99 != null)
				{
					System.Boolean ifResult100; //IsContext = False IsNew = False
					
					
					System.Single OperandVar102 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop101 = StoredVariable99.People; //IsContext = False IsNew = False
					OperandVar102 = prop101;
					
					
					
					System.Boolean OperandVar104 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable98 != null)
					{
						System.Boolean prop103 = StoredVariable98.IsActive; //IsContext = False IsNew = False
						OperandVar104 = prop103;
					}
					if(ifResult100 = ( (( ( (OperandVar102))) < ( ( (1f))))) && ( (!(OperandVar104))))
					{
						applicable = true;
						OperandVar105 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar105);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.ruler_role subContext106 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext106 ContextSwitchInterpreter
				if(subContext106 != null)
				{
					System.Single OperandVar108 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop107 = subContext106.People; //IsContext = False IsNew = False
					OperandVar108 = prop107;
					
					subContext106.People = (System.Single)(( (OperandVar108)) * ( (1.2f)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class order_a_wunderwaffe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar121 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable109 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable109 != null)
			{
				Blackboards.ruler_role StoredVariable110 = ((Blackboards.ruler_role)StoredVariable109.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable110 != null)
				{
					Blackboards.foe_role StoredVariable111 = ((Blackboards.foe_role)StoredVariable110.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable111 != null)
					{
						System.Boolean ifResult112; //IsContext = False IsNew = False
						
						System.Boolean OperandVar114 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable109 != null)
						{
							System.Boolean prop113 = StoredVariable109.IsActive; //IsContext = False IsNew = False
							OperandVar114 = prop113;
						}
						
						System.Boolean OperandVar120 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar116 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable110 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop115 = StoredVariable110.AtWarWith; //IsContext = False IsNew = False
							if(prop115 != null)
							{
								OperandVar116 = prop115;
							}
						}
						UnityEngine.GameObject OperandVar118 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop117 = StoredVariable111.Enemy; //IsContext = False IsNew = False
						if(prop117 != null)
						{
							OperandVar118 = prop117;
						}
						System.Boolean prop119 = External.Contains( (OperandVar116), (OperandVar118)); //IsContext = False IsNew = False
						OperandVar120 = prop119;
						if(ifResult112 = ( ( (OperandVar114))) && ( ( (OperandVar120))))
						{
							applicable = true;
							OperandVar121 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar121);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar124 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable122 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable122 != null)
			{
				System.Single prop123 = StoredVariable122.ThreatLevel; //IsContext = False IsNew = False
				OperandVar124 = prop123;
			}
			
			return (System.Single)( (OperandVar124)) * ( (0.3f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject wunder_waffe = new UnityEngine.GameObject("wunder_waffe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wunder_waffe125 = wunder_waffe; //IsContext = True IsNew = False
				Actor AddContext126 = (Actor)wunder_waffe.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.buildable AddContext127 = (Blackboards.buildable)wunder_waffe.AddComponent(typeof(Blackboards.buildable)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.buildable AddContext127 ContextSwitchInterpreter
					if(AddContext127 != null)
					{
						
						AddContext127.Cost = (System.Single)( (20f));
					}
				}
				Blackboards.old_weapon AddContext128 = (Blackboards.old_weapon)wunder_waffe.AddComponent(typeof(Blackboards.old_weapon)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wunder_waffe);
			
			{
				Blackboards.ruler_role subContext129 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext129 ContextSwitchInterpreter
				if(subContext129 != null)
				{
					UnityEngine.GameObject OperandVar130 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar130 = wunder_waffe;
					subContext129.Wunderwaffe = (UnityEngine.GameObject)( (OperandVar130));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class genius_found : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar140 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable131 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable131 != null)
			{
				Blackboards.ruler_role StoredVariable132 = ((Blackboards.ruler_role)StoredVariable131.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable132 != null)
				{
					System.Boolean ifResult133; //IsContext = False IsNew = False
					
					System.Boolean OperandVar137 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop134 = StoredVariable132.Wunderwaffe; //IsContext = False IsNew = False
					if(prop134 != null)
					{
						Blackboards.old_weapon StoredVariable135 = ((Blackboards.old_weapon)prop134.GetComponent(typeof(Blackboards.old_weapon))); //IsContext = False IsNew = False
						if(StoredVariable135 != null)
						{
							Blackboards.buildable StoredVariable136 = ((Blackboards.buildable)StoredVariable135.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
							if(StoredVariable136 != null)
							{
								applicable = true;
								OperandVar137 = applicable;
							}
						}
					}
					
					System.Boolean OperandVar139 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable131 != null)
					{
						System.Boolean prop138 = StoredVariable131.IsActive; //IsContext = False IsNew = False
						OperandVar139 = prop138;
					}
					if(ifResult133 = ( ( (OperandVar137))) && ( (!(OperandVar139))))
					{
						applicable = true;
						OperandVar140 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar140);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject genius = new UnityEngine.GameObject("genius"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject genius141 = genius; //IsContext = True IsNew = False
				Actor AddContext142 = (Actor)genius.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.worker AddContext143 = (Blackboards.worker)genius.AddComponent(typeof(Blackboards.worker)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.worker AddContext143 ContextSwitchInterpreter
					if(AddContext143 != null)
					{
						UnityEngine.GameObject OperandVar144 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar144 = root;
						AddContext143.WorksFor = (UnityEngine.GameObject)( (OperandVar144));
					}
				}
				Blackboards.builder AddContext145 = (Blackboards.builder)genius.AddComponent(typeof(Blackboards.builder)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(genius);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class commence_battle : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar161 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable146 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable146 != null)
			{
				Blackboards.ruler_role StoredVariable147 = ((Blackboards.ruler_role)StoredVariable146.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable147 != null)
				{
					Blackboards.foe_role StoredVariable148 = ((Blackboards.foe_role)StoredVariable147.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable148 != null)
					{
						System.Boolean ifResult149; //IsContext = False IsNew = False
						
						System.Boolean OperandVar151 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable146 != null)
						{
							System.Boolean prop150 = StoredVariable146.IsActive; //IsContext = False IsNew = False
							OperandVar151 = prop150;
						}
						
						System.Boolean OperandVar157 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar153 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable147 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop152 = StoredVariable147.AtWarWith; //IsContext = False IsNew = False
							if(prop152 != null)
							{
								OperandVar153 = prop152;
							}
						}
						UnityEngine.GameObject OperandVar155 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop154 = StoredVariable148.Enemy; //IsContext = False IsNew = False
						if(prop154 != null)
						{
							OperandVar155 = prop154;
						}
						System.Boolean prop156 = External.Contains( (OperandVar153), (OperandVar155)); //IsContext = False IsNew = False
						OperandVar157 = prop156;
						
						System.Boolean OperandVar160 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop158 = StoredVariable148.Enemy; //IsContext = False IsNew = False
						if(prop158 != null)
						{
							Blackboards.ruler_role StoredVariable159 = ((Blackboards.ruler_role)prop158.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable159 != null)
							{
								applicable = true;
								OperandVar160 = applicable;
							}
						}
						if(ifResult149 = ( ( (OperandVar151))) && ( ( (OperandVar157))) && ( ( (OperandVar160))))
						{
							applicable = true;
							OperandVar161 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar161);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar164 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable162 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable162 != null)
			{
				System.Single prop163 = StoredVariable162.ThreatLevel; //IsContext = False IsNew = False
				OperandVar164 = prop163;
			}
			return (System.Single)( (1f)) / ( (OperandVar164));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject battle_event = new UnityEngine.GameObject("battle_event"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject battle_event165 = battle_event; //IsContext = True IsNew = False
				Event AddContext166 = (Event)battle_event.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext166 ContextSwitchInterpreter
					if(AddContext166 != null)
					{
						UnityEngine.GameObject OperandVar167 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar167 = root;
						AddContext166.Context = (UnityEngine.GameObject)( (OperandVar167));
					}
				}
				Blackboards.targeted_event AddContext168 = (Blackboards.targeted_event)battle_event.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext168 ContextSwitchInterpreter
					if(AddContext168 != null)
					{
						UnityEngine.GameObject OperandVar171 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.foe_role StoredVariable169 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
						if(StoredVariable169 != null)
						{
							UnityEngine.GameObject prop170 = StoredVariable169.Enemy; //IsContext = False IsNew = False
							if(prop170 != null)
							{
								OperandVar171 = prop170;
							}
						}
						AddContext168.Target = (UnityEngine.GameObject)( (OperandVar171));
					}
				}
				Blackboards.battle_event AddContext172 = (Blackboards.battle_event)battle_event.AddComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(battle_event);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class battle_calculation : EventAction {
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar185 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable173 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable173 != null)
			{
				Blackboards.battle_event StoredVariable174 = ((Blackboards.battle_event)StoredVariable173.GetComponent(typeof(Blackboards.battle_event))); //IsContext = False IsNew = False
				if(StoredVariable174 != null)
				{
					Blackboards.targeted_event StoredVariable175 = ((Blackboards.targeted_event)StoredVariable174.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
					if(StoredVariable175 != null)
					{
						System.Boolean ifResult176; //IsContext = False IsNew = False
						
						System.Boolean OperandVar180 = default(System.Boolean); //IsContext = False IsNew = False
						Event StoredVariable177 = ((Event)StoredVariable175.GetComponent(typeof(Event))); //IsContext = False IsNew = False
						if(StoredVariable177 != null)
						{
							UnityEngine.GameObject prop178 = StoredVariable177.Context; //IsContext = False IsNew = False
							if(prop178 != null)
							{
								Blackboards.ruler_role StoredVariable179 = ((Blackboards.ruler_role)prop178.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable179 != null)
								{
									applicable = true;
									OperandVar180 = applicable;
								}
							}
						}
						
						System.Boolean OperandVar184 = default(System.Boolean); //IsContext = False IsNew = False
						Blackboards.targeted_event StoredVariable181 = ((Blackboards.targeted_event)StoredVariable175.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
						if(StoredVariable181 != null)
						{
							UnityEngine.GameObject prop182 = StoredVariable181.Target; //IsContext = False IsNew = False
							if(prop182 != null)
							{
								Blackboards.ruler_role StoredVariable183 = ((Blackboards.ruler_role)prop182.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable183 != null)
								{
									applicable = true;
									OperandVar184 = applicable;
								}
							}
						}
						if(ifResult176 = ( ( (OperandVar180))) && ( ( (OperandVar184))))
						{
							applicable = true;
							OperandVar185 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar185);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			System.Single OperandVar187 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop186 = External.Intensity(); //IsContext = False IsNew = False
			OperandVar187 = prop186;
			
			System.Single intensity_multiplier = ( ( (1f))) + ( (( (OperandVar187)) * ( (4f)))); //IsContext = False IsNew = False
			Blackboards.ruler_role OperandVar191 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
			Event StoredVariable188 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable188 != null)
			{
				UnityEngine.GameObject prop189 = StoredVariable188.Context; //IsContext = False IsNew = False
				if(prop189 != null)
				{
					Blackboards.ruler_role StoredVariable190 = ((Blackboards.ruler_role)prop189.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable190 != null)
					{
						OperandVar191 = StoredVariable190;
					}
				}
			}
			Blackboards.ruler_role first =  (OperandVar191); //IsContext = False IsNew = False
			Blackboards.ruler_role OperandVar195 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
			Blackboards.targeted_event StoredVariable192 = ((Blackboards.targeted_event)root.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
			if(StoredVariable192 != null)
			{
				UnityEngine.GameObject prop193 = StoredVariable192.Target; //IsContext = False IsNew = False
				if(prop193 != null)
				{
					Blackboards.ruler_role StoredVariable194 = ((Blackboards.ruler_role)prop193.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable194 != null)
					{
						OperandVar195 = StoredVariable194;
					}
				}
			}
			Blackboards.ruler_role second =  (OperandVar195); //IsContext = False IsNew = False
			System.Single OperandVar197 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop196 = first.Forces; //IsContext = False IsNew = False
			OperandVar197 = prop196;
			System.Single pre_battle_first =  (OperandVar197); //IsContext = False IsNew = False
			System.Single OperandVar199 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop198 = second.Forces; //IsContext = False IsNew = False
			OperandVar199 = prop198;
			System.Single pre_battle_second =  (OperandVar199); //IsContext = False IsNew = False
			
			System.Single OperandVar201 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop200 = first.Forces; //IsContext = False IsNew = False
			OperandVar201 = prop200;
			
			System.Single OperandVar203 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop202 = second.Forces; //IsContext = False IsNew = False
			OperandVar203 = prop202;
			if(( ( (OperandVar201))) > ( ( (OperandVar203))))
			{
				
				{
					//ContextStatement Blackboards.ruler_role second ContextSwitchInterpreter
					if(second != null)
					{
						System.Single OperandVar205 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop204 = second.Forces; //IsContext = False IsNew = False
						OperandVar205 = prop204;
						
						System.Single OperandVar206 = default(System.Single); //IsContext = False IsNew = False
						OperandVar206 = intensity_multiplier;
						second.Forces = (System.Single)(( (OperandVar205)) / ( (2f)) / ( (OperandVar206)));
					}
				}
				
				{
					//ContextStatement Blackboards.ruler_role first ContextSwitchInterpreter
					if(first != null)
					{
						System.Single OperandVar208 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop207 = first.Forces; //IsContext = False IsNew = False
						OperandVar208 = prop207;
						System.Single OperandVar209 = default(System.Single); //IsContext = False IsNew = False
						OperandVar209 = intensity_multiplier;
						first.Forces = (System.Single)(( (OperandVar208)) / ( (OperandVar209)));
					}
				}
				
				{
					Blackboards.battle_event subContext210 = (Blackboards.battle_event)root.GetComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.battle_event subContext210 ContextSwitchInterpreter
					if(subContext210 != null)
					{
						UnityEngine.GameObject OperandVar213 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar211 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar211 = first;
						UnityEngine.GameObject prop212 = External.Gameobject( (OperandVar211)); //IsContext = False IsNew = False
						if(prop212 != null)
						{
							OperandVar213 = prop212;
						}
						subContext210.Won = (UnityEngine.GameObject)( (OperandVar213));
						UnityEngine.GameObject OperandVar216 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar214 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar214 = second;
						UnityEngine.GameObject prop215 = External.Gameobject( (OperandVar214)); //IsContext = False IsNew = False
						if(prop215 != null)
						{
							OperandVar216 = prop215;
						}
						subContext210.Lost = (UnityEngine.GameObject)( (OperandVar216));
						
						System.Single OperandVar217 = default(System.Single); //IsContext = False IsNew = False
						OperandVar217 = pre_battle_first;
						
						System.Single OperandVar219 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop218 = first.Forces; //IsContext = False IsNew = False
						OperandVar219 = prop218;
						subContext210.WinnerForcesLost = (System.Single)(( ( (OperandVar217))) - ( ( (OperandVar219))));
						
						System.Single OperandVar220 = default(System.Single); //IsContext = False IsNew = False
						OperandVar220 = pre_battle_second;
						
						System.Single OperandVar222 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop221 = second.Forces; //IsContext = False IsNew = False
						OperandVar222 = prop221;
						subContext210.LooserForcesLost = (System.Single)(( ( (OperandVar220))) - ( ( (OperandVar222))));
					}
				}
			}
			
			System.Single OperandVar224 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop223 = first.Forces; //IsContext = False IsNew = False
			OperandVar224 = prop223;
			
			System.Single OperandVar226 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop225 = second.Forces; //IsContext = False IsNew = False
			OperandVar226 = prop225;
			if(( ( (OperandVar224))) < ( ( (OperandVar226))))
			{
				
				{
					//ContextStatement Blackboards.ruler_role first ContextSwitchInterpreter
					if(first != null)
					{
						System.Single OperandVar228 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop227 = first.Forces; //IsContext = False IsNew = False
						OperandVar228 = prop227;
						
						System.Single OperandVar229 = default(System.Single); //IsContext = False IsNew = False
						OperandVar229 = intensity_multiplier;
						first.Forces = (System.Single)(( (OperandVar228)) / ( (2f)) / ( (OperandVar229)));
					}
				}
				
				{
					//ContextStatement Blackboards.ruler_role second ContextSwitchInterpreter
					if(second != null)
					{
						System.Single OperandVar231 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop230 = second.Forces; //IsContext = False IsNew = False
						OperandVar231 = prop230;
						System.Single OperandVar232 = default(System.Single); //IsContext = False IsNew = False
						OperandVar232 = intensity_multiplier;
						second.Forces = (System.Single)(( (OperandVar231)) / ( (OperandVar232)));
					}
				}
				
				{
					Blackboards.battle_event subContext233 = (Blackboards.battle_event)root.GetComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.battle_event subContext233 ContextSwitchInterpreter
					if(subContext233 != null)
					{
						UnityEngine.GameObject OperandVar236 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar234 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar234 = second;
						UnityEngine.GameObject prop235 = External.Gameobject( (OperandVar234)); //IsContext = False IsNew = False
						if(prop235 != null)
						{
							OperandVar236 = prop235;
						}
						subContext233.Won = (UnityEngine.GameObject)( (OperandVar236));
						UnityEngine.GameObject OperandVar239 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar237 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar237 = first;
						UnityEngine.GameObject prop238 = External.Gameobject( (OperandVar237)); //IsContext = False IsNew = False
						if(prop238 != null)
						{
							OperandVar239 = prop238;
						}
						subContext233.Lost = (UnityEngine.GameObject)( (OperandVar239));
						
						System.Single OperandVar240 = default(System.Single); //IsContext = False IsNew = False
						OperandVar240 = pre_battle_first;
						
						System.Single OperandVar242 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop241 = first.Forces; //IsContext = False IsNew = False
						OperandVar242 = prop241;
						subContext233.LooserForcesLost = (System.Single)(( ( (OperandVar240))) - ( ( (OperandVar242))));
						
						System.Single OperandVar243 = default(System.Single); //IsContext = False IsNew = False
						OperandVar243 = pre_battle_second;
						
						System.Single OperandVar245 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop244 = second.Forces; //IsContext = False IsNew = False
						OperandVar245 = prop244;
						subContext233.WinnerForcesLost = (System.Single)(( ( (OperandVar243))) - ( ( (OperandVar245))));
					}
				}
			}
			
			System.Single OperandVar247 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop246 = first.Forces; //IsContext = False IsNew = False
			OperandVar247 = prop246;
			
			System.Single OperandVar249 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop248 = second.Forces; //IsContext = False IsNew = False
			OperandVar249 = prop248;
			if(( ( (OperandVar247))) == ( ( (OperandVar249))))
			{
				
				{
					Blackboards.battle_event subContext250 = (Blackboards.battle_event)root.GetComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.battle_event subContext250 ContextSwitchInterpreter
					if(subContext250 != null)
					{
						
						subContext250.Tie = (System.Boolean)( (true));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class build_wunderwaffe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar266 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable251 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable251 != null)
			{
				Blackboards.builder StoredVariable252 = ((Blackboards.builder)StoredVariable251.GetComponent(typeof(Blackboards.builder))); //IsContext = False IsNew = False
				if(StoredVariable252 != null)
				{
					Blackboards.worker StoredVariable253 = ((Blackboards.worker)StoredVariable252.GetComponent(typeof(Blackboards.worker))); //IsContext = False IsNew = False
					if(StoredVariable253 != null)
					{
						System.Boolean ifResult254; //IsContext = False IsNew = False
						
						System.Boolean OperandVar256 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable251 != null)
						{
							System.Boolean prop255 = StoredVariable251.IsActive; //IsContext = False IsNew = False
							OperandVar256 = prop255;
						}
						
						System.Boolean OperandVar265 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop257 = StoredVariable253.WorksFor; //IsContext = False IsNew = False
						if(prop257 != null)
						{
							Blackboards.ruler_role StoredVariable258 = ((Blackboards.ruler_role)prop257.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable258 != null)
							{
								System.Boolean ifResult259; //IsContext = False IsNew = False
								
								Blackboards.ruler_role OperandVar260 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
								OperandVar260 = StoredVariable258;
								
								System.Boolean OperandVar264 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject prop261 = StoredVariable258.Wunderwaffe; //IsContext = False IsNew = False
								if(prop261 != null)
								{
									Blackboards.buildable StoredVariable262 = ((Blackboards.buildable)prop261.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
									if(StoredVariable262 != null)
									{
										System.Boolean prop263 = StoredVariable262.Finished; //IsContext = False IsNew = False
										OperandVar264 = prop263;
									}
								}
								if(ifResult259 = ( ( (OperandVar260))) && ( (!(OperandVar264))))
								{
									OperandVar265 = ifResult259;
								}
							}
						}
						if(ifResult254 = ( ( (OperandVar256))) && ( ( (OperandVar265))))
						{
							applicable = true;
							OperandVar266 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar266);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject act = new UnityEngine.GameObject("act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject act267 = act; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext268 = (Blackboards.notify_event)act.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext268 ContextSwitchInterpreter
					if(AddContext268 != null)
					{
						UnityEngine.GameObject OperandVar269 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar269 = root;
						AddContext268.Who = (UnityEngine.GameObject)( (OperandVar269));
						
						AddContext268.Data = (System.String)( ("build_wunderwaffe"));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(act);
			
			{
				Blackboards.worker subContext270 = (Blackboards.worker)root.GetComponent(typeof(Blackboards.worker)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.worker subContext270 ContextSwitchInterpreter
				if(subContext270 != null)
				{
					
					{
						UnityEngine.GameObject subContext271 = subContext270.WorksFor; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext271 ContextPropertySwitchInterpreter
						if(subContext271 != null)
						{
							
							{
								Blackboards.ruler_role subContext272 = (Blackboards.ruler_role)subContext271.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext272 ContextSwitchInterpreter
								if(subContext272 != null)
								{
									
									{
										UnityEngine.GameObject subContext273 = subContext272.Wunderwaffe; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext273 ContextPropertySwitchInterpreter
										if(subContext273 != null)
										{
											
											{
												Blackboards.buildable subContext274 = (Blackboards.buildable)subContext273.GetComponent(typeof(Blackboards.buildable)); //IsContext = True IsNew = False
												//ContextStatement Blackboards.buildable subContext274 ContextSwitchInterpreter
												if(subContext274 != null)
												{
													
													System.Single OperandVar276 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop275 = subContext274.CurrentInvestment; //IsContext = False IsNew = False
													OperandVar276 = prop275;
													
													
													subContext274.CurrentInvestment = (System.Single)(( ( (OperandVar276))) + ( ( (5f))));
													
													System.Single OperandVar278 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop277 = subContext274.CurrentInvestment; //IsContext = False IsNew = False
													OperandVar278 = prop277;
													
													System.Single OperandVar280 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop279 = subContext274.Cost; //IsContext = False IsNew = False
													OperandVar280 = prop279;
													if(( ( (OperandVar278))) >= ( ( (OperandVar280))))
													{
														
														subContext274.Finished = (System.Boolean)( (true));
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class test_wunderwaffe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar304 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable281 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable281 != null)
			{
				Blackboards.ruler_role StoredVariable282 = ((Blackboards.ruler_role)StoredVariable281.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable282 != null)
				{
					Blackboards.foe_role StoredVariable283 = ((Blackboards.foe_role)StoredVariable282.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable283 != null)
					{
						System.Boolean ifResult284; //IsContext = False IsNew = False
						
						System.Boolean OperandVar286 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable281 != null)
						{
							System.Boolean prop285 = StoredVariable281.IsActive; //IsContext = False IsNew = False
							OperandVar286 = prop285;
						}
						
						System.Boolean OperandVar292 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar288 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable282 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop287 = StoredVariable282.AtWarWith; //IsContext = False IsNew = False
							if(prop287 != null)
							{
								OperandVar288 = prop287;
							}
						}
						UnityEngine.GameObject OperandVar290 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop289 = StoredVariable283.Enemy; //IsContext = False IsNew = False
						if(prop289 != null)
						{
							OperandVar290 = prop289;
						}
						System.Boolean prop291 = External.Contains( (OperandVar288), (OperandVar290)); //IsContext = False IsNew = False
						OperandVar292 = prop291;
						
						System.Boolean OperandVar295 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop293 = StoredVariable283.Enemy; //IsContext = False IsNew = False
						if(prop293 != null)
						{
							Blackboards.ruler_role StoredVariable294 = ((Blackboards.ruler_role)prop293.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable294 != null)
							{
								applicable = true;
								OperandVar295 = applicable;
							}
						}
						
						System.Boolean OperandVar299 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar297 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable282 != null)
						{
							UnityEngine.GameObject prop296 = StoredVariable282.Wunderwaffe; //IsContext = False IsNew = False
							if(prop296 != null)
							{
								OperandVar297 = prop296;
							}
						}
						System.Boolean prop298 = External.Has( (OperandVar297)); //IsContext = False IsNew = False
						OperandVar299 = prop298;
						
						System.Boolean OperandVar303 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable282 != null)
						{
							UnityEngine.GameObject prop300 = StoredVariable282.Wunderwaffe; //IsContext = False IsNew = False
							if(prop300 != null)
							{
								Blackboards.buildable StoredVariable301 = ((Blackboards.buildable)prop300.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
								if(StoredVariable301 != null)
								{
									System.Boolean prop302 = StoredVariable301.Finished; //IsContext = False IsNew = False
									OperandVar303 = prop302;
								}
							}
						}
						if(ifResult284 = ( ( (OperandVar286))) && ( ( (OperandVar292))) && ( ( (OperandVar295))) && ( ( (OperandVar299))) && ( ( (OperandVar303))))
						{
							applicable = true;
							OperandVar304 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar304);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar307 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable305 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable305 != null)
			{
				System.Single prop306 = StoredVariable305.ThreatLevel; //IsContext = False IsNew = False
				OperandVar307 = prop306;
			}
			
			return (System.Single)( (OperandVar307)) * ( (0.5f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject act = new UnityEngine.GameObject("act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject act308 = act; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext309 = (Blackboards.notify_event)act.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext309 ContextSwitchInterpreter
					if(AddContext309 != null)
					{
						UnityEngine.GameObject OperandVar310 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar310 = root;
						AddContext309.Who = (UnityEngine.GameObject)( (OperandVar310));
						
						AddContext309.Data = (System.String)( ("test_wunderwaffe"));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(act);
			
			{
				Blackboards.foe_role subContext311 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext311 ContextSwitchInterpreter
				if(subContext311 != null)
				{
					
					{
						UnityEngine.GameObject subContext312 = subContext311.Enemy; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext312 ContextPropertySwitchInterpreter
						if(subContext312 != null)
						{
							
							{
								Blackboards.ruler_role subContext313 = (Blackboards.ruler_role)subContext312.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext313 ContextSwitchInterpreter
								if(subContext313 != null)
								{
									
									System.Single OperandVar315 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop314 = subContext313.Forces; //IsContext = False IsNew = False
									OperandVar315 = prop314;
									
									
									subContext313.Forces = (System.Single)(( ( (OperandVar315))) - ( ( (10f))));
									
									subContext313.People = (System.Single)( (0f));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar320 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable316 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable316 != null)
			{
				System.Boolean ifResult317; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar319 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop318 = StoredVariable316.Places; //IsContext = False IsNew = False
				if(prop318 != null)
				{
					OperandVar319 = prop318;
				}
				
				
				if(ifResult317 = ( ( (OperandVar319 != null ? OperandVar319.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar320 = applicable;
				}
			}
			return (System.Boolean) (OperandVar320);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext321 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext321 ContextSwitchInterpreter
				if(subContext321 != null)
				{
					
					subContext321.Size = (System.Int32)( (5f));
					System.Single OperandVar323 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop322 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar323 = prop322;
					for (int i = 0; i <  (OperandVar323); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc324 = loc; //IsContext = True IsNew = False
							Entity AddContext325 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext325 ContextSwitchInterpreter
								if(AddContext325 != null)
								{
									UnityEngine.Vector3 OperandVar335 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar329 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar327 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop326 = External.MapX(); //IsContext = False IsNew = False
									OperandVar327 = prop326;
									System.Single prop328 = External.Random( (0f), (OperandVar327)); //IsContext = False IsNew = False
									OperandVar329 = prop328;
									System.Single OperandVar333 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar331 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop330 = External.MapX(); //IsContext = False IsNew = False
									OperandVar331 = prop330;
									System.Single prop332 = External.Random( (0f), (OperandVar331)); //IsContext = False IsNew = False
									OperandVar333 = prop332;
									UnityEngine.Vector3 prop334 = External.Vec( (OperandVar329), (OperandVar333)); //IsContext = False IsNew = False
									OperandVar335 = prop334;
									AddContext325.Position = (UnityEngine.Vector3)( (OperandVar335));
								}
							}
							Place AddContext336 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext336 ContextSwitchInterpreter
								if(AddContext336 != null)
								{
									System.Single OperandVar338 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop337 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar338 = prop337;
									AddContext336.Size = (System.Int32)( (OperandVar338));
								}
							}
							Markers AddContext339 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext339 ContextSwitchInterpreter
								if(AddContext339 != null)
								{
									System.String OperandVar340 = default(System.String); //IsContext = False IsNew = False
									OperandVar340 = "history_place";
									AddContext339.SetMarker(( (OperandVar340)).ToString());
								}
							}
							Named AddContext341 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext341 ContextSwitchInterpreter
								if(AddContext341 != null)
								{
									
									
									
									AddContext341.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar344 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar342 = default(System.String); //IsContext = False IsNew = False
									OperandVar342 = "human_name";
									System.String prop343 = External.RandomName( (OperandVar342)); //IsContext = False IsNew = False
									if(prop343 != null)
									{
										OperandVar344 = prop343;
									}
									AddContext341.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar344)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar346 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable345 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable345 != null)
						{
							OperandVar346 = StoredVariable345;
						}
						subContext321.Attach((Place)( (OperandVar346)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar360 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable347 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable347 != null)
			{
				Markers StoredVariable348 = ((Markers)StoredVariable347.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable348 != null)
				{
					System.Boolean ifResult349; //IsContext = False IsNew = False
					
					System.Boolean OperandVar356 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable347 != null)
					{
						UnityEngine.GameObject prop350 = StoredVariable347.ShowedObject; //IsContext = False IsNew = False
						if(prop350 != null)
						{
							System.Boolean ifResult351; //IsContext = False IsNew = False
							System.Boolean OperandVar355 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar353 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable352 = ((Named)prop350.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable352 != null)
							{
								OperandVar353 = StoredVariable352;
							}
							System.Boolean prop354 = External.Has( (OperandVar353)); //IsContext = False IsNew = False
							OperandVar355 = prop354;
							if(ifResult351 =  (OperandVar355))
							{
								OperandVar356 = ifResult351;
							}
						}
					}
					
					System.Boolean OperandVar359 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar357 = default(System.String); //IsContext = False IsNew = False
					OperandVar357 = "named_ui_marker";
					System.Boolean prop358 = StoredVariable348.HasMarker( (OperandVar357)); //IsContext = False IsNew = False
					OperandVar359 = prop358;
					if(ifResult349 = ( ( (OperandVar356))) && ( (!(OperandVar359))))
					{
						applicable = true;
						OperandVar360 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar360);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext361 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext361 ContextSwitchInterpreter
				if(subContext361 != null)
				{
					System.String OperandVar362 = default(System.String); //IsContext = False IsNew = False
					OperandVar362 = "named_ui_marker";
					subContext361.SetUiMarker(( (OperandVar362)).ToString());
				}
			}
			
			{
				UiObject subContext363 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext363 ContextSwitchInterpreter
				if(subContext363 != null)
				{
					Named OperandVar366 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop364 = subContext363.ShowedObject; //IsContext = False IsNew = False
					if(prop364 != null)
					{
						Named StoredVariable365 = ((Named)prop364.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable365 != null)
						{
							OperandVar366 = StoredVariable365;
						}
					}
					Named showed_named =  (OperandVar366); //IsContext = False IsNew = False
					TextField ContextVar367 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar367 ContextSwitchInterpreter
						if(ContextVar367 != null)
						{
							System.String OperandVar369 = default(System.String); //IsContext = False IsNew = False
							System.String prop368 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop368 != null)
							{
								OperandVar369 = prop368;
							}
							ContextVar367.Show(( (OperandVar369)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda370 = () => 
									{
										System.String OperandVar372 = default(System.String); //IsContext = False IsNew = False
										System.String prop371 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop371 != null)
										{
											OperandVar372 = prop371;
										}
										ContextVar367.Show(( (OperandVar372)).ToString());
									};
									showed_named.OnUpdate(Lambda370);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext373 = ContextVar367.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext373 ContextPropertySwitchInterpreter
								if(subContext373 != null)
								{
									
									subContext373.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar374 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar374 != null) EntVar374.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar383 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable375 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable375 != null)
			{
				Place StoredVariable376 = ((Place)StoredVariable375.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable376 != null)
				{
					System.Boolean ifResult377; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar379 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop378 = StoredVariable376.Agents; //IsContext = False IsNew = False
					if(prop378 != null)
					{
						OperandVar379 = prop378;
					}
					
					
					
					System.Boolean OperandVar382 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar380 = default(System.String); //IsContext = False IsNew = False
					OperandVar380 = "agents_pool";
					System.Boolean prop381 = StoredVariable375.HasMarker( (OperandVar380)); //IsContext = False IsNew = False
					OperandVar382 = prop381;
					if(ifResult377 = ( (( ( (OperandVar379 != null ? OperandVar379.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar382))))
					{
						applicable = true;
						OperandVar383 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar383);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext384 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext384 ContextSwitchInterpreter
				if(subContext384 != null)
				{
					
					subContext384.Size = (System.Int32)( (5f));
					System.Single OperandVar386 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop385 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar386 = prop385;
					for (int i = 0; i <  (OperandVar386); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag387 = ag; //IsContext = True IsNew = False
							Entity AddContext388 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext389 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext390 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext390 ContextSwitchInterpreter
								if(AddContext390 != null)
								{
									System.Single OperandVar392 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop391 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar392 = prop391;
									AddContext390.Age = (System.Int32)( (OperandVar392));
								}
							}
							Named AddContext393 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext393 ContextSwitchInterpreter
								if(AddContext393 != null)
								{
									
									
									
									AddContext393.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar396 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar394 = default(System.String); //IsContext = False IsNew = False
									OperandVar394 = "human_name";
									System.String prop395 = External.RandomName( (OperandVar394)); //IsContext = False IsNew = False
									if(prop395 != null)
									{
										OperandVar396 = prop395;
									}
									AddContext393.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar396)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar398 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable397 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable397 != null)
						{
							OperandVar398 = StoredVariable397;
						}
						subContext384.Attach((Agent)( (OperandVar398)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar405 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable399 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable399 != null)
			{
				System.Boolean ifResult400; //IsContext = False IsNew = False
				System.Boolean OperandVar404 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar402 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable401 = ((Blackboards.event_marker)StoredVariable399.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable401 != null)
				{
					OperandVar402 = StoredVariable401;
				}
				System.Boolean prop403 = External.Has( (OperandVar402)); //IsContext = False IsNew = False
				OperandVar404 = prop403;
				if(ifResult400 = !(OperandVar404))
				{
					applicable = true;
					OperandVar405 = applicable;
				}
			}
			return (System.Boolean) (OperandVar405);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar406 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar406 != null) EntVar406.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar413 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable407 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable407 != null)
			{
				System.Boolean ifResult408; //IsContext = False IsNew = False
				System.Boolean OperandVar412 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar410 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable409 = ((Blackboards.personality)StoredVariable407.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable409 != null)
				{
					OperandVar410 = StoredVariable409;
				}
				System.Boolean prop411 = External.Has( (OperandVar410)); //IsContext = False IsNew = False
				OperandVar412 = prop411;
				if(ifResult408 = !(OperandVar412))
				{
					applicable = true;
					OperandVar413 = applicable;
				}
			}
			return (System.Boolean) (OperandVar413);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar414 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar414 != null) EntVar414.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar421 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable415 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable415 != null)
			{
				System.Boolean ifResult416; //IsContext = False IsNew = False
				System.Boolean OperandVar420 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar418 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable417 = ((Blackboards.aged_generation)StoredVariable415.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable417 != null)
				{
					OperandVar418 = StoredVariable417;
				}
				System.Boolean prop419 = External.Has( (OperandVar418)); //IsContext = False IsNew = False
				OperandVar420 = prop419;
				if(ifResult416 = !(OperandVar420))
				{
					applicable = true;
					OperandVar421 = applicable;
				}
			}
			return (System.Boolean) (OperandVar421);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar422 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar422 != null) EntVar422.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar432 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable423 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable423 != null)
			{
				Lore StoredVariable424 = ((Lore)StoredVariable423.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable424 != null)
				{
					Place StoredVariable425 = ((Place)StoredVariable424.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable425 != null)
					{
						System.Boolean ifResult426; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar428 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop427 = StoredVariable425.Agents; //IsContext = False IsNew = False
						if(prop427 != null)
						{
							OperandVar428 = prop427;
						}
						
						
						
						System.Boolean OperandVar431 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar429 = default(System.String); //IsContext = False IsNew = False
						OperandVar429 = "lore_pool";
						System.Boolean prop430 = StoredVariable423.HasMarker( (OperandVar429)); //IsContext = False IsNew = False
						OperandVar431 = prop430;
						if(ifResult426 = ( (( ( (OperandVar428 != null ? OperandVar428.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar431))))
						{
							applicable = true;
							OperandVar432 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar432);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext433 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext433 ContextSwitchInterpreter
				if(subContext433 != null)
				{
					
					subContext433.Size = (System.Int32)( (10f));
					System.Single OperandVar435 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop434 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar435 = prop434;
					for (int i = 0; i <  (OperandVar435); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag436 = old_ag; //IsContext = True IsNew = False
							Entity AddContext437 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext438 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext439 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext440 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext440 ContextSwitchInterpreter
								if(AddContext440 != null)
								{
									System.Single OperandVar442 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop441 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar442 = prop441;
									AddContext440.Age = (System.Int32)( (OperandVar442));
								}
							}
							Named AddContext443 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext443 ContextSwitchInterpreter
								if(AddContext443 != null)
								{
									
									
									
									AddContext443.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar446 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar444 = default(System.String); //IsContext = False IsNew = False
									OperandVar444 = "human_name";
									System.String prop445 = External.RandomName( (OperandVar444)); //IsContext = False IsNew = False
									if(prop445 != null)
									{
										OperandVar446 = prop445;
									}
									AddContext443.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar446)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar448 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable447 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable447 != null)
						{
							OperandVar448 = StoredVariable447;
						}
						subContext433.Attach((Agent)( (OperandVar448)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar454 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable449 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable449 != null)
			{
				Named StoredVariable450 = ((Named)StoredVariable449.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable450 != null)
				{
					System.Boolean ifResult451; //IsContext = False IsNew = False
					
					System.Boolean OperandVar453 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable449 != null)
					{
						System.Boolean prop452 = StoredVariable449.Act; //IsContext = False IsNew = False
						OperandVar453 = prop452;
					}
					
					
					if(ifResult451 = ( ( (OperandVar453))) == ( ( (true))))
					{
						applicable = true;
						OperandVar454 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar454);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar458 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable455 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable455 != null)
			{
				System.String OperandVar456 = default(System.String); //IsContext = False IsNew = False
				OperandVar456 = "main_name";
				System.String prop457 = StoredVariable455.Get( (OperandVar456)); //IsContext = False IsNew = False
				if(prop457 != null)
				{
					OperandVar458 = prop457;
				}
			}
			External.Log((System.Object)( (OperandVar458)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar466 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable459 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable459 != null)
			{
				Agent StoredVariable460 = ((Agent)StoredVariable459.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable460 != null)
				{
					System.Boolean ifResult461; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar463 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop462 = StoredVariable460.Act; //IsContext = False IsNew = False
					OperandVar463 = prop462;
					
					
					
					System.Boolean OperandVar465 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable459 != null)
					{
						System.Boolean prop464 = StoredVariable459.Dead; //IsContext = False IsNew = False
						OperandVar465 = prop464;
					}
					if(ifResult461 = ( (( ( (OperandVar463))) == ( ( (true))))) && ( (!(OperandVar465))))
					{
						applicable = true;
						OperandVar466 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar466);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar467 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar467 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar467)))));
			UnityEngine.GameObject OperandVar468 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar468 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar468)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar478 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable469 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable469 != null)
			{
				Markers StoredVariable470 = ((Markers)StoredVariable469.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable470 != null)
				{
					System.Boolean ifResult471; //IsContext = False IsNew = False
					
					System.Boolean OperandVar474 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar472 = default(System.String); //IsContext = False IsNew = False
					OperandVar472 = "map_anchored";
					System.Boolean prop473 = StoredVariable470.HasMarker( (OperandVar472)); //IsContext = False IsNew = False
					OperandVar474 = prop473;
					
					System.Boolean OperandVar477 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar475 = default(System.String); //IsContext = False IsNew = False
					OperandVar475 = "history_place";
					System.Boolean prop476 = StoredVariable470.HasMarker( (OperandVar475)); //IsContext = False IsNew = False
					OperandVar477 = prop476;
					if(ifResult471 = ( (!(OperandVar474))) && ( ( (OperandVar477))))
					{
						applicable = true;
						OperandVar478 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar478);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext479 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext479 ContextSwitchInterpreter
				if(subContext479 != null)
				{
					System.String OperandVar480 = default(System.String); //IsContext = False IsNew = False
					OperandVar480 = "map_anchored";
					subContext479.SetUiMarker(( (OperandVar480)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar481 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar481 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar481)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar488 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable482 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable482 != null)
			{
				Markers StoredVariable483 = ((Markers)StoredVariable482.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable483 != null)
				{
					System.Boolean ifResult484; //IsContext = False IsNew = False
					System.Boolean OperandVar487 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar485 = default(System.String); //IsContext = False IsNew = False
					OperandVar485 = "encounter_ui_enlist";
					System.Boolean prop486 = StoredVariable483.HasMarker( (OperandVar485)); //IsContext = False IsNew = False
					OperandVar487 = prop486;
					if(ifResult484 = !(OperandVar487))
					{
						applicable = true;
						OperandVar488 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar488);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext489 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext489 ContextSwitchInterpreter
				if(subContext489 != null)
				{
					System.String OperandVar490 = default(System.String); //IsContext = False IsNew = False
					OperandVar490 = "encounter_ui_enlist";
					subContext489.SetUiMarker(( (OperandVar490)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar491 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar491 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar491)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar497 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable492 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable492 != null)
			{
				Named StoredVariable493 = ((Named)StoredVariable492.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable493 != null)
				{
					System.Boolean ifResult494; //IsContext = False IsNew = False
					
					System.Boolean OperandVar496 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable492 != null)
					{
						System.Boolean prop495 = StoredVariable492.Act; //IsContext = False IsNew = False
						OperandVar496 = prop495;
					}
					
					
					if(ifResult494 = ( ( (OperandVar496))) == ( ( (true))))
					{
						applicable = true;
						OperandVar497 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar497);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.4f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject enc = new UnityEngine.GameObject("enc"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject enc498 = enc; //IsContext = True IsNew = False
				Encounter AddContext499 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext499 ContextSwitchInterpreter
					if(AddContext499 != null)
					{
						UnityEngine.GameObject OperandVar500 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar500 = root;
						AddContext499.Context = (UnityEngine.GameObject)( (OperandVar500));
					}
				}
				Markers AddContext501 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext502 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext503 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext503 ContextSwitchInterpreter
					if(AddContext503 != null)
					{
						System.String OperandVar504 = default(System.String); //IsContext = False IsNew = False
						OperandVar504 = "main_name";
						
						
						AddContext503.Set(( (OperandVar504)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar518 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable505 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable505 != null)
			{
				Markers StoredVariable506 = ((Markers)StoredVariable505.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable506 != null)
				{
					System.Boolean ifResult507; //IsContext = False IsNew = False
					
					System.Boolean OperandVar514 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable505 != null)
					{
						UnityEngine.GameObject prop508 = StoredVariable505.ShowedObject; //IsContext = False IsNew = False
						if(prop508 != null)
						{
							System.Boolean ifResult509; //IsContext = False IsNew = False
							System.Boolean OperandVar513 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar511 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable510 = ((Place)prop508.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable510 != null)
							{
								OperandVar511 = StoredVariable510;
							}
							System.Boolean prop512 = External.Has( (OperandVar511)); //IsContext = False IsNew = False
							OperandVar513 = prop512;
							if(ifResult509 =  (OperandVar513))
							{
								OperandVar514 = ifResult509;
							}
						}
					}
					
					System.Boolean OperandVar517 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar515 = default(System.String); //IsContext = False IsNew = False
					OperandVar515 = "place_ui_cards_list";
					System.Boolean prop516 = StoredVariable506.HasMarker( (OperandVar515)); //IsContext = False IsNew = False
					OperandVar517 = prop516;
					if(ifResult507 = ( ( (OperandVar514))) && ( (!(OperandVar517))))
					{
						applicable = true;
						OperandVar518 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar518);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext519 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext519 ContextSwitchInterpreter
				if(subContext519 != null)
				{
					System.String OperandVar520 = default(System.String); //IsContext = False IsNew = False
					OperandVar520 = "place_ui_cards_list";
					subContext519.SetUiMarker(( (OperandVar520)).ToString());
				}
			}
			Place OperandVar524 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable521 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable521 != null)
			{
				UnityEngine.GameObject prop522 = StoredVariable521.ShowedObject; //IsContext = False IsNew = False
				if(prop522 != null)
				{
					Place StoredVariable523 = ((Place)prop522.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable523 != null)
					{
						OperandVar524 = StoredVariable523;
					}
				}
			}
			Place pl =  (OperandVar524); //IsContext = False IsNew = False
			System.String OperandVar525 = default(System.String); //IsContext = False IsNew = False
			OperandVar525 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx526 = External.SpawnPrefab(( (OperandVar525)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx526 ContextPropertySwitchInterpreter
				if(FuncCtx526 != null)
				{
					
					{
						AgentsUI subContext527 = (AgentsUI)FuncCtx526.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext527 ContextSwitchInterpreter
						if(subContext527 != null)
						{
							Place OperandVar528 = default(Place); //IsContext = False IsNew = False
							OperandVar528 = pl;
							subContext527.TargetPlace = (Place)( (OperandVar528));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext529 = (CardsHolderAgentsAdapter)FuncCtx526.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext529 ContextSwitchInterpreter
						if(subContext529 != null)
						{
							Place OperandVar530 = default(Place); //IsContext = False IsNew = False
							OperandVar530 = pl;
							subContext529.TargetPlace = (Place)( (OperandVar530));
						}
					}
					UnityEngine.GameObject OperandVar531 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar531 = FuncCtx526;
					UnityEngine.GameObject OperandVar532 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar532 = root;
					External.SetParent((UnityEngine.GameObject)( (OperandVar531)),(UnityEngine.GameObject)( (OperandVar532)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false)]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar538 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable533 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable533 != null)
			{
				System.Boolean ifResult534; //IsContext = False IsNew = False
				System.Boolean OperandVar537 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop535 = StoredVariable533.ShowedObject; //IsContext = False IsNew = False
				if(prop535 != null)
				{
					Place StoredVariable536 = ((Place)prop535.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable536 != null)
					{
						applicable = true;
						OperandVar537 = applicable;
					}
				}
				if(ifResult534 =  (OperandVar537))
				{
					applicable = true;
					OperandVar538 = applicable;
				}
			}
			return (System.Boolean) (OperandVar538);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			TextField ContextVar539 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement TextField ContextVar539 ContextSwitchInterpreter
				if(ContextVar539 != null)
				{
					
					ContextVar539.Label = (System.String)( ("size"));
					System.Int32 OperandVar544 = default(System.Int32); //IsContext = False IsNew = False
					UiObject StoredVariable540 = ((UiObject)ContextVar539.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
					if(StoredVariable540 != null)
					{
						UnityEngine.GameObject prop541 = StoredVariable540.ShowedObject; //IsContext = False IsNew = False
						if(prop541 != null)
						{
							Place StoredVariable542 = ((Place)prop541.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable542 != null)
							{
								System.Int32 prop543 = StoredVariable542.Size; //IsContext = False IsNew = False
								OperandVar544 = prop543;
							}
						}
					}
					ContextVar539.Show(( (OperandVar544)).ToString());
					
					{
						UnityEngine.UI.LayoutElement subContext545 = ContextVar539.Layout; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.UI.LayoutElement subContext545 ContextPropertySwitchInterpreter
						if(subContext545 != null)
						{
							
							subContext545.minHeight = (System.Single)( (20f));
						}
					}
				}
			}
			Entity EntVar546 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar546 != null) EntVar546.ComponentAdded();
		}
        }
    }
}
