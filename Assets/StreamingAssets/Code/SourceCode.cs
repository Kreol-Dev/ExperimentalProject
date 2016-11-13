namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class country_cities : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar5 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable0 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar2 = default(System.String); //IsContext = False IsNew = False
				OperandVar2 = "country_node";
				System.Boolean prop3 = StoredVariable0.HasMarker( (OperandVar2)); //IsContext = False IsNew = False
				OperandVar4 = prop3;
				if(ifResult1 =  (OperandVar4))
				{
					applicable = true;
					OperandVar5 = applicable;
				}
			}
			return (System.Boolean) (OperandVar5);
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
			
			root.AddComponent<Blackboards.country>();
			Entity EntVar6 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar6 != null) EntVar6.ComponentAdded();
			System.Single OperandVar8 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop7 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
			OperandVar8 = prop7;
			for (int i = 0; i <  (OperandVar8); i++)
			{
				UnityEngine.GameObject city_obj = new UnityEngine.GameObject("city_obj"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject city_obj9 = city_obj; //IsContext = True IsNew = False
					Entity AddContext10 = (Entity)city_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Entity AddContext10 ContextSwitchInterpreter
						if(AddContext10 != null)
						{
							
							UnityEngine.Vector3 OperandVar16 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
							System.Single OperandVar12 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop11 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar12 = prop11;
							System.Single OperandVar14 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop13 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar14 = prop13;
							UnityEngine.Vector3 prop15 = External.Vec( (OperandVar12), (OperandVar14)); //IsContext = False IsNew = False
							OperandVar16 = prop15;
							AddContext10.Position = (UnityEngine.Vector3)( (OperandVar16));
						}
					}
					Place AddContext17 = (Place)city_obj.AddComponent(typeof(Place)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Place AddContext17 ContextSwitchInterpreter
						if(AddContext17 != null)
						{
							
							
							AddContext17.Size = (System.Int32)( (100f));
						}
					}
					Named AddContext18 = (Named)city_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Named AddContext18 ContextSwitchInterpreter
						if(AddContext18 != null)
						{
							
							System.String OperandVar19 = default(System.String); //IsContext = False IsNew = False
							OperandVar19 = "main_name";
							
							System.String OperandVar22 = default(System.String); //IsContext = False IsNew = False
							System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
							OperandVar20 = "country_name";
							System.String prop21 = External.RandomName( (OperandVar20)); //IsContext = False IsNew = False
							if(prop21 != null)
							{
								OperandVar22 = prop21;
							}
							AddContext18.Set(( (OperandVar19)).ToString(),(System.Single)( (0f)),( (OperandVar22)).ToString());
						}
					}
					Interactables AddContext23 = (Interactables)city_obj.AddComponent(typeof(Interactables)); //IsContext = True IsNew = True
					Interactable AddContext24 = (Interactable)city_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
					Blackboards.city AddContext25 = (Blackboards.city)city_obj.AddComponent(typeof(Blackboards.city)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.city AddContext25 ContextSwitchInterpreter
						if(AddContext25 != null)
						{
							
							System.Single OperandVar27 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop26 = External.Random( (3f), (6f)); //IsContext = False IsNew = False
							OperandVar27 = prop26;
							AddContext25.Size = (System.Int32)( (OperandVar27));
							UnityEngine.GameObject OperandVar28 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar28 = root;
							AddContext25.Of = (UnityEngine.GameObject)( (OperandVar28));
						}
					}
					Actor AddContext29 = (Actor)city_obj.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(city_obj, 0.1f);
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cult_generation : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable30 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable30 != null)
			{
				System.Boolean ifResult31; //IsContext = False IsNew = False
				
				System.Boolean OperandVar34 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar32 = default(System.String); //IsContext = False IsNew = False
				OperandVar32 = "cult_node";
				System.Boolean prop33 = StoredVariable30.HasMarker( (OperandVar32)); //IsContext = False IsNew = False
				OperandVar34 = prop33;
				
				System.Boolean OperandVar42 = default(System.Boolean); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> OperandVar36 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> prop35 = External.AllActors; //IsContext = False IsNew = False
				if(prop35 != null)
				{
					OperandVar36 = prop35;
				}
				System.Boolean prop41 = External.Any( (OperandVar36),(UnityEngine.GameObject go)=>{;
System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.noble OperandVar38 = default(Blackboards.noble); //IsContext = False IsNew = False;
Blackboards.noble StoredVariable37 = ((Blackboards.noble)go.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False;
if(StoredVariable37 != null)
					{
						OperandVar38 = StoredVariable37;
					};
System.Boolean prop39 = External.Has( (OperandVar38)); //IsContext = False IsNew = False;
OperandVar40 = prop39;;
return  (OperandVar40);}); //IsContext = False IsNew = False
				OperandVar42 = prop41;
				if(ifResult31 = ( ( (OperandVar34))) && ( ( (OperandVar42))))
				{
					applicable = true;
					OperandVar43 = applicable;
				}
			}
			return (System.Boolean) (OperandVar43);
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
			
			
			External.Log((System.Object)( ("generating cult")));
			
			System.Single noble_per_cultist =  (4f); //IsContext = False IsNew = False
			
			System.Single current_noble =  (0f); //IsContext = False IsNew = False
			for (int i44 = 0; External.AllActors != null && i44 < External.AllActors.Count; i44++)
			{
				UnityEngine.GameObject iter45 = External.AllActors[i44]; //IsContext = True IsNew = True
				
				{
					//ContextStatement UnityEngine.GameObject iter45 ContextSwitchInterpreter
					if(iter45 != null)
					{
						
						
						{
							Blackboards.noble subContext46 = (Blackboards.noble)iter45.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
							//ContextStatement Blackboards.noble subContext46 ContextSwitchInterpreter
							if(subContext46 != null)
							{
								
								
								System.Single OperandVar47 = default(System.Single); //IsContext = False IsNew = False
								OperandVar47 = current_noble;
								
								System.Single OperandVar48 = default(System.Single); //IsContext = False IsNew = False
								OperandVar48 = noble_per_cultist;
								if(( ( (OperandVar47))) >= ( ( (OperandVar48))))
								{
									
									current_noble =  (0f);
									
									
									
									Blackboards.noble OperandVar49 = default(Blackboards.noble); //IsContext = False IsNew = False
									OperandVar49 = subContext46;
									External.Log((System.Object)(( ( ("cultist = "))) + ( ( (OperandVar49)))));
									iter45.AddComponent<Blackboards.cultist>();
									Entity EntVar50 = (Entity)iter45.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
									if(EntVar50 != null) EntVar50.ComponentAdded();
								}
								
								System.Single OperandVar51 = default(System.Single); //IsContext = False IsNew = False
								OperandVar51 = current_noble;
								
								
								current_noble = ( ( (OperandVar51))) + ( ( (1f)));
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class noble_is_a_cultist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar73 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable52 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable52 != null)
			{
				Blackboards.noble StoredVariable53 = ((Blackboards.noble)StoredVariable52.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable53 != null)
				{
					System.Boolean ifResult54; //IsContext = False IsNew = False
					
					System.Boolean OperandVar56 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable52 != null)
					{
						System.Boolean prop55 = StoredVariable52.Generated; //IsContext = False IsNew = False
						OperandVar56 = prop55;
					}
					
					
					System.Int32 OperandVar58 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop57 = External.CurrentDate(); //IsContext = False IsNew = False
					OperandVar58 = prop57;
					
					
					
					System.Boolean OperandVar62 = default(System.Boolean); //IsContext = False IsNew = False
					Blackboards.cultist OperandVar60 = default(Blackboards.cultist); //IsContext = False IsNew = False
					Blackboards.cultist StoredVariable59 = ((Blackboards.cultist)StoredVariable53.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
					if(StoredVariable59 != null)
					{
						OperandVar60 = StoredVariable59;
					}
					System.Boolean prop61 = External.Has( (OperandVar60)); //IsContext = False IsNew = False
					OperandVar62 = prop61;
					
					System.Boolean OperandVar72 = default(System.Boolean); //IsContext = False IsNew = False
					System.Collections.Generic.List<UnityEngine.GameObject> OperandVar66 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
					UnityEngine.GameObject prop63 = StoredVariable53.Where; //IsContext = False IsNew = False
					if(prop63 != null)
					{
						Interactables StoredVariable64 = ((Interactables)prop63.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
						if(StoredVariable64 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop65 = StoredVariable64.Every; //IsContext = False IsNew = False
							if(prop65 != null)
							{
								OperandVar66 = prop65;
							}
						}
					}
					System.Boolean prop71 = External.Any( (OperandVar66),(UnityEngine.GameObject go)=>{;
System.Boolean OperandVar70 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.cultist OperandVar68 = default(Blackboards.cultist); //IsContext = False IsNew = False;
Blackboards.cultist StoredVariable67 = ((Blackboards.cultist)go.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False;
if(StoredVariable67 != null)
						{
							OperandVar68 = StoredVariable67;
						};
System.Boolean prop69 = External.Has( (OperandVar68)); //IsContext = False IsNew = False;
OperandVar70 = prop69;;
return  (OperandVar70);}); //IsContext = False IsNew = False
					OperandVar72 = prop71;
					if(ifResult54 = ( (!(OperandVar56))) && ( (( ( (OperandVar58))) > ( ( (0f))))) && ( (!(OperandVar62))) && ( ( (OperandVar72))))
					{
						applicable = true;
						OperandVar73 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar73);
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
			
			
			System.Single OperandVar75 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop74 = External.Random( (0f), (5f)); //IsContext = False IsNew = False
			OperandVar75 = prop74;
			
			
			if(( ( (OperandVar75))) > ( ( (2f))))
			{
				root.AddComponent<Blackboards.cultist>();
				Entity EntVar76 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
				if(EntVar76 != null) EntVar76.ComponentAdded();
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cultist_power : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar83 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable77 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable77 != null)
			{
				Blackboards.noble StoredVariable78 = ((Blackboards.noble)StoredVariable77.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable78 != null)
				{
					Blackboards.cultist StoredVariable79 = ((Blackboards.cultist)StoredVariable78.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
					if(StoredVariable79 != null)
					{
						System.Boolean ifResult80; //IsContext = False IsNew = False
						System.Boolean OperandVar82 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable77 != null)
						{
							System.Boolean prop81 = StoredVariable77.IsActive; //IsContext = False IsNew = False
							OperandVar82 = prop81;
						}
						if(ifResult80 = !(OperandVar82))
						{
							applicable = true;
							OperandVar83 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar83);
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
				Blackboards.cultist subContext84 = (Blackboards.cultist)root.GetComponent(typeof(Blackboards.cultist)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.cultist subContext84 ContextSwitchInterpreter
				if(subContext84 != null)
				{
					
					
					{
						Blackboards.noble subContext85 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
						//ContextStatement Blackboards.noble subContext85 ContextSwitchInterpreter
						if(subContext85 != null)
						{
							
							
							
							System.Single OperandVar87 = default(System.Single); //IsContext = False IsNew = False
							System.Single prop86 = subContext85.Knowledge; //IsContext = False IsNew = False
							OperandVar87 = prop86;
							
							System.Single OperandVar89 = default(System.Single); //IsContext = False IsNew = False
							System.Single prop88 = subContext85.Occult; //IsContext = False IsNew = False
							OperandVar89 = prop88;
							
							subContext84.Power = (System.Single)(( (( ( (OperandVar87))) + ( ( (OperandVar89))))) / ( (2f)));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cultist_perform_ritual : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar95 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable90 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable90 != null)
			{
				Blackboards.cultist StoredVariable91 = ((Blackboards.cultist)StoredVariable90.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
				if(StoredVariable91 != null)
				{
					System.Boolean ifResult92; //IsContext = False IsNew = False
					System.Boolean OperandVar94 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable90 != null)
					{
						System.Boolean prop93 = StoredVariable90.IsActive; //IsContext = False IsNew = False
						OperandVar94 = prop93;
					}
					if(ifResult92 =  (OperandVar94))
					{
						applicable = true;
						OperandVar95 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar95);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar98 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.cultist StoredVariable96 = ((Blackboards.cultist)root.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
			if(StoredVariable96 != null)
			{
				System.Single prop97 = StoredVariable96.Power; //IsContext = False IsNew = False
				OperandVar98 = prop97;
			}
			return (System.Single) (OperandVar98);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject cast_ritual = new UnityEngine.GameObject("cast_ritual"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cast_ritual99 = cast_ritual; //IsContext = True IsNew = False
				Event AddContext100 = (Event)cast_ritual.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext100 ContextSwitchInterpreter
					if(AddContext100 != null)
					{
						
						UnityEngine.GameObject OperandVar101 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar101 = root;
						AddContext100.Context = (UnityEngine.GameObject)( (OperandVar101));
					}
				}
				Blackboards.ritual AddContext102 = (Blackboards.ritual)cast_ritual.AddComponent(typeof(Blackboards.ritual)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cast_ritual, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cultist_try_convert_other : EventAction {
        
        private UnityEngine.GameObject other_non_cultist;
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar109 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable103 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable103 != null)
			{
				Blackboards.cultist StoredVariable104 = ((Blackboards.cultist)StoredVariable103.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
				if(StoredVariable104 != null)
				{
					Blackboards.noble StoredVariable105 = ((Blackboards.noble)StoredVariable104.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
					if(StoredVariable105 != null)
					{
						System.Boolean ifResult106; //IsContext = False IsNew = False
						System.Boolean OperandVar108 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable103 != null)
						{
							System.Boolean prop107 = StoredVariable103.IsActive; //IsContext = False IsNew = False
							OperandVar108 = prop107;
						}
						if(ifResult106 =  (OperandVar108))
						{
							applicable = true;
							OperandVar109 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar109);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			UnityEngine.GameObject OperandVar120 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> OperandVar114 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable110 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable110 != null)
			{
				UnityEngine.GameObject prop111 = StoredVariable110.Where; //IsContext = False IsNew = False
				if(prop111 != null)
				{
					Interactables StoredVariable112 = ((Interactables)prop111.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable112 != null)
					{
						System.Collections.Generic.List<UnityEngine.GameObject> prop113 = StoredVariable112.Every; //IsContext = False IsNew = False
						if(prop113 != null)
						{
							OperandVar114 = prop113;
						}
					}
				}
			}
			UnityEngine.GameObject prop119 = External.RandomFrom( (OperandVar114),(UnityEngine.GameObject go)=>{;
System.Boolean OperandVar118 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.cultist OperandVar116 = default(Blackboards.cultist); //IsContext = False IsNew = False;
Blackboards.cultist StoredVariable115 = ((Blackboards.cultist)go.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False;
if(StoredVariable115 != null)
				{
					OperandVar116 = StoredVariable115;
				};
System.Boolean prop117 = External.Has( (OperandVar116)); //IsContext = False IsNew = False;
OperandVar118 = prop117;;
return !(OperandVar118);}); //IsContext = False IsNew = False
			if(prop119 != null)
			{
				OperandVar120 = prop119;
			}
			other_non_cultist =  (OperandVar120);
			
			System.Boolean OperandVar123 = default(System.Boolean); //IsContext = False IsNew = False
			UnityEngine.GameObject OperandVar121 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar121 = other_non_cultist;
			System.Boolean prop122 = External.Has( (OperandVar121)); //IsContext = False IsNew = False
			OperandVar123 = prop122;
			if( (OperandVar123))
			{
				System.Single OperandVar125 = default(System.Single); //IsContext = False IsNew = False
				if(StoredVariable110 != null)
				{
					System.Single prop124 = StoredVariable110.Influence; //IsContext = False IsNew = False
					OperandVar125 = prop124;
				}
				ut =  (OperandVar125);
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			UnityEngine.GameObject convert_other = new UnityEngine.GameObject("convert_other"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject convert_other126 = convert_other; //IsContext = True IsNew = False
				Event AddContext127 = (Event)convert_other.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext127 ContextSwitchInterpreter
					if(AddContext127 != null)
					{
						
						UnityEngine.GameObject OperandVar128 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar128 = root;
						AddContext127.Context = (UnityEngine.GameObject)( (OperandVar128));
					}
				}
				Blackboards.targeted_event AddContext129 = (Blackboards.targeted_event)convert_other.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext129 ContextSwitchInterpreter
					if(AddContext129 != null)
					{
						
						UnityEngine.GameObject OperandVar130 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar130 = other_non_cultist;
						AddContext129.Target = (UnityEngine.GameObject)( (OperandVar130));
					}
				}
				Blackboards.conversion_attempt AddContext131 = (Blackboards.conversion_attempt)convert_other.AddComponent(typeof(Blackboards.conversion_attempt)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(convert_other, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_convesion_attempt : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar135 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable132 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable132 != null)
			{
				Blackboards.conversion_attempt StoredVariable133 = ((Blackboards.conversion_attempt)StoredVariable132.GetComponent(typeof(Blackboards.conversion_attempt))); //IsContext = False IsNew = False
				if(StoredVariable133 != null)
				{
					Blackboards.targeted_event StoredVariable134 = ((Blackboards.targeted_event)StoredVariable133.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
					if(StoredVariable134 != null)
					{
						applicable = true;
						OperandVar135 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar135);
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
			
			Blackboards.noble OperandVar139 = default(Blackboards.noble); //IsContext = False IsNew = False
			Event StoredVariable136 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable136 != null)
			{
				UnityEngine.GameObject prop137 = StoredVariable136.Context; //IsContext = False IsNew = False
				if(prop137 != null)
				{
					Blackboards.noble StoredVariable138 = ((Blackboards.noble)prop137.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
					if(StoredVariable138 != null)
					{
						OperandVar139 = StoredVariable138;
					}
				}
			}
			Blackboards.noble converter =  (OperandVar139); //IsContext = False IsNew = False
			Blackboards.noble OperandVar143 = default(Blackboards.noble); //IsContext = False IsNew = False
			Blackboards.targeted_event StoredVariable140 = ((Blackboards.targeted_event)root.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
			if(StoredVariable140 != null)
			{
				UnityEngine.GameObject prop141 = StoredVariable140.Target; //IsContext = False IsNew = False
				if(prop141 != null)
				{
					Blackboards.noble StoredVariable142 = ((Blackboards.noble)prop141.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
					if(StoredVariable142 != null)
					{
						OperandVar143 = StoredVariable142;
					}
				}
			}
			Blackboards.noble converted =  (OperandVar143); //IsContext = False IsNew = False
			
			System.Single OperandVar145 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop144 = converter.Influence; //IsContext = False IsNew = False
			OperandVar145 = prop144;
			
			System.Single OperandVar147 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop146 = converted.Sanity; //IsContext = False IsNew = False
			OperandVar147 = prop146;
			if(( ( (OperandVar145))) > ( ( (OperandVar147))))
			{
				
				{
					Blackboards.targeted_event subContext148 = (Blackboards.targeted_event)root.GetComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.targeted_event subContext148 ContextSwitchInterpreter
					if(subContext148 != null)
					{
						
						
						{
							UnityEngine.GameObject subContext149 = subContext148.Target; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.GameObject subContext149 ContextPropertySwitchInterpreter
							if(subContext149 != null)
							{
								subContext149.AddComponent<Blackboards.cultist>();
								Entity EntVar150 = (Entity)subContext149.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
								if(EntVar150 != null) EntVar150.ComponentAdded();
							}
						}
					}
				}
				
				{
					Event subContext151 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
					//ContextStatement Event subContext151 ContextSwitchInterpreter
					if(subContext151 != null)
					{
						
						root.AddComponent<Blackboards.noble_converted>();
						Entity EntVar152 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
						if(EntVar152 != null) EntVar152.ComponentAdded();
					}
				}
			}
			
			System.Single OperandVar154 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop153 = converter.Influence; //IsContext = False IsNew = False
			OperandVar154 = prop153;
			
			System.Single OperandVar156 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop155 = converted.Sanity; //IsContext = False IsNew = False
			OperandVar156 = prop155;
			if(( ( (OperandVar154))) < ( ( (OperandVar156))))
			{
				
				{
					Event subContext157 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
					//ContextStatement Event subContext157 ContextSwitchInterpreter
					if(subContext157 != null)
					{
						
						root.AddComponent<Blackboards.noble_not_converted>();
						Entity EntVar158 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
						if(EntVar158 != null) EntVar158.ComponentAdded();
					}
				}
			}
			
			{
				Blackboards.targeted_event subContext159 = (Blackboards.targeted_event)root.GetComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.targeted_event subContext159 ContextSwitchInterpreter
				if(subContext159 != null)
				{
					
					
					{
						UnityEngine.GameObject subContext160 = subContext159.Target; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext160 ContextPropertySwitchInterpreter
						if(subContext160 != null)
						{
							
							{
								Blackboards.noble subContext161 = (Blackboards.noble)subContext160.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.noble subContext161 ContextSwitchInterpreter
								if(subContext161 != null)
								{
									
									
									System.Boolean OperandVar165 = default(System.Boolean); //IsContext = False IsNew = False
									Blackboards.cultist OperandVar163 = default(Blackboards.cultist); //IsContext = False IsNew = False
									Blackboards.cultist StoredVariable162 = ((Blackboards.cultist)subContext161.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
									if(StoredVariable162 != null)
									{
										OperandVar163 = StoredVariable162;
									}
									System.Boolean prop164 = External.Has( (OperandVar163)); //IsContext = False IsNew = False
									OperandVar165 = prop164;
									
									
									
									
									System.Single OperandVar167 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop166 = subContext161.Loyalty; //IsContext = False IsNew = False
									OperandVar167 = prop166;
									
									System.Single OperandVar169 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop168 = subContext161.Sanity; //IsContext = False IsNew = False
									OperandVar169 = prop168;
									
									
									System.Single OperandVar172 = default(System.Single); //IsContext = False IsNew = False
									Blackboards.personality StoredVariable170 = ((Blackboards.personality)subContext161.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
									if(StoredVariable170 != null)
									{
										System.Single prop171 = StoredVariable170.Brave; //IsContext = False IsNew = False
										OperandVar172 = prop171;
									}
									if(( (!(OperandVar165))) && ( (( (( (( ( (OperandVar167))) + ( ( (OperandVar169))))) / ( (2f)))) > ( ( (OperandVar172))))))
									{
										
										
										
										System.String OperandVar175 = default(System.String); //IsContext = False IsNew = False
										Named StoredVariable173 = ((Named)converter.GetComponent(typeof(Named))); //IsContext = False IsNew = False
										if(StoredVariable173 != null)
										{
											System.String prop174 = StoredVariable173.FullName; //IsContext = False IsNew = False
											if(prop174 != null)
											{
												OperandVar175 = prop174;
											}
										}
										External.Notify((( ( ("He tried to persuade me to join a cult "))) + ( ( (OperandVar175)))).ToString());
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class ritual_steps : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar181 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable176 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable176 != null)
			{
				Blackboards.ritual StoredVariable177 = ((Blackboards.ritual)StoredVariable176.GetComponent(typeof(Blackboards.ritual))); //IsContext = False IsNew = False
				if(StoredVariable177 != null)
				{
					System.Boolean ifResult178; //IsContext = False IsNew = False
					
					System.Int32 OperandVar180 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop179 = StoredVariable177.Step; //IsContext = False IsNew = False
					OperandVar180 = prop179;
					
					
					if(ifResult178 = ( ( (OperandVar180))) < ( ( (3f))))
					{
						applicable = true;
						OperandVar181 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar181);
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
				Blackboards.ritual subContext182 = (Blackboards.ritual)root.GetComponent(typeof(Blackboards.ritual)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ritual subContext182 ContextSwitchInterpreter
				if(subContext182 != null)
				{
					
					
					System.Int32 OperandVar184 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop183 = subContext182.Step; //IsContext = False IsNew = False
					OperandVar184 = prop183;
					
					
					subContext182.Step = (System.Int32)(( ( (OperandVar184))) + ( ( (1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_ritual : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar192 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable185 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable185 != null)
			{
				Blackboards.ritual StoredVariable186 = ((Blackboards.ritual)StoredVariable185.GetComponent(typeof(Blackboards.ritual))); //IsContext = False IsNew = False
				if(StoredVariable186 != null)
				{
					System.Boolean ifResult187; //IsContext = False IsNew = False
					
					
					System.Int32 OperandVar189 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop188 = StoredVariable186.Step; //IsContext = False IsNew = False
					OperandVar189 = prop188;
					
					
					
					System.Boolean OperandVar191 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop190 = StoredVariable186.Interrupted; //IsContext = False IsNew = False
					OperandVar191 = prop190;
					if(ifResult187 = ( (( ( (OperandVar189))) == ( ( (3f))))) && ( (!(OperandVar191))))
					{
						applicable = true;
						OperandVar192 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar192);
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
				Event subContext193 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
				//ContextStatement Event subContext193 ContextSwitchInterpreter
				if(subContext193 != null)
				{
					
					
					{
						UnityEngine.GameObject subContext194 = subContext193.Context; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext194 ContextPropertySwitchInterpreter
						if(subContext194 != null)
						{
							
							{
								Blackboards.cultist subContext195 = (Blackboards.cultist)subContext194.GetComponent(typeof(Blackboards.cultist)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.cultist subContext195 ContextSwitchInterpreter
								if(subContext195 != null)
								{
									
									
									System.Single OperandVar197 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop196 = subContext195.Power; //IsContext = False IsNew = False
									OperandVar197 = prop196;
									
									
									if(( ( (OperandVar197))) > ( ( (0.25f))))
									{
										
										{
											Blackboards.noble subContext198 = (Blackboards.noble)subContext194.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
											//ContextStatement Blackboards.noble subContext198 ContextSwitchInterpreter
											if(subContext198 != null)
											{
												
												
												System.Single OperandVar200 = default(System.Single); //IsContext = False IsNew = False
												System.Single prop199 = subContext198.Occult; //IsContext = False IsNew = False
												OperandVar200 = prop199;
												
												
												subContext198.Occult = (System.Single)(( ( (OperandVar200))) + ( ( (0.1f))));
											}
										}
									}
									
									System.Single OperandVar202 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop201 = subContext195.Power; //IsContext = False IsNew = False
									OperandVar202 = prop201;
									
									
									if(( ( (OperandVar202))) > ( ( (0.5f))))
									{
										
										{
											Blackboards.noble subContext203 = (Blackboards.noble)subContext194.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
											//ContextStatement Blackboards.noble subContext203 ContextSwitchInterpreter
											if(subContext203 != null)
											{
												
												
												System.Single OperandVar205 = default(System.Single); //IsContext = False IsNew = False
												System.Single prop204 = subContext203.Influence; //IsContext = False IsNew = False
												OperandVar205 = prop204;
												
												
												subContext203.Influence = (System.Single)(( ( (OperandVar205))) + ( ( (0.1f))));
											}
										}
										
										System.Int32 OperandVar207 = default(System.Int32); //IsContext = False IsNew = False
										System.Int32 prop206 = External.Sanity; //IsContext = False IsNew = False
										OperandVar207 = prop206;
										
										
										External.Sanity = (System.Int32)(( ( (OperandVar207))) - ( ( (1f))));
									}
									
									System.Single OperandVar209 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop208 = subContext195.Power; //IsContext = False IsNew = False
									OperandVar209 = prop208;
									
									
									if(( ( (OperandVar209))) > ( ( (0.9f))))
									{
										
										{
											Blackboards.noble subContext210 = (Blackboards.noble)subContext194.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
											//ContextStatement Blackboards.noble subContext210 ContextSwitchInterpreter
											if(subContext210 != null)
											{
												
												
												{
													UnityEngine.GameObject subContext211 = subContext210.Where; //IsContext = True IsNew = False
													//ContextStatement UnityEngine.GameObject subContext211 ContextPropertySwitchInterpreter
													if(subContext211 != null)
													{
														
														{
															Interactables subContext212 = (Interactables)subContext211.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
															//ContextStatement Interactables subContext212 ContextSwitchInterpreter
															if(subContext212 != null)
															{
																
																
																{
																	//ContextStatement Blackboards.noble subContext210 ContextSwitchInterpreter
																	if(subContext210 != null)
																	{
																		
																		
																		System.Single OperandVar214 = default(System.Single); //IsContext = False IsNew = False
																		System.Single prop213 = subContext210.Sanity; //IsContext = False IsNew = False
																		OperandVar214 = prop213;
																		
																		
																		subContext210.Sanity = (System.Single)(( ( (OperandVar214))) - ( ( (0.1f))));
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
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class ritual_interrupted : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar222 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable215 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable215 != null)
			{
				Blackboards.interrupt_ritual_attempt StoredVariable216 = ((Blackboards.interrupt_ritual_attempt)StoredVariable215.GetComponent(typeof(Blackboards.interrupt_ritual_attempt))); //IsContext = False IsNew = False
				if(StoredVariable216 != null)
				{
					System.Boolean ifResult217; //IsContext = False IsNew = False
					System.Boolean OperandVar221 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar219 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable215 != null)
					{
						UnityEngine.GameObject prop218 = StoredVariable215.Context; //IsContext = False IsNew = False
						if(prop218 != null)
						{
							OperandVar219 = prop218;
						}
					}
					System.Boolean prop220 = External.Has( (OperandVar219)); //IsContext = False IsNew = False
					OperandVar221 = prop220;
					if(ifResult217 =  (OperandVar221))
					{
						applicable = true;
						OperandVar222 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar222);
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
			
			
			
			
			System.Int32 OperandVar227 = default(System.Int32); //IsContext = False IsNew = False
			Event StoredVariable223 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable223 != null)
			{
				UnityEngine.GameObject prop224 = StoredVariable223.Context; //IsContext = False IsNew = False
				if(prop224 != null)
				{
					Blackboards.attributes StoredVariable225 = ((Blackboards.attributes)prop224.GetComponent(typeof(Blackboards.attributes))); //IsContext = False IsNew = False
					if(StoredVariable225 != null)
					{
						System.Int32 prop226 = StoredVariable225.Intellect; //IsContext = False IsNew = False
						OperandVar227 = prop226;
					}
				}
			}
			
			System.Int32 OperandVar231 = default(System.Int32); //IsContext = False IsNew = False
			if(StoredVariable223 != null)
			{
				UnityEngine.GameObject prop228 = StoredVariable223.Context; //IsContext = False IsNew = False
				if(prop228 != null)
				{
					Blackboards.attributes StoredVariable229 = ((Blackboards.attributes)prop228.GetComponent(typeof(Blackboards.attributes))); //IsContext = False IsNew = False
					if(StoredVariable229 != null)
					{
						System.Int32 prop230 = StoredVariable229.Mental; //IsContext = False IsNew = False
						OperandVar231 = prop230;
					}
				}
			}
			
			
			System.Single OperandVar238 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.interrupt_ritual_attempt StoredVariable232 = ((Blackboards.interrupt_ritual_attempt)root.GetComponent(typeof(Blackboards.interrupt_ritual_attempt))); //IsContext = False IsNew = False
			if(StoredVariable232 != null)
			{
				UnityEngine.GameObject prop233 = StoredVariable232.TargetRitual; //IsContext = False IsNew = False
				if(prop233 != null)
				{
					Event StoredVariable234 = ((Event)prop233.GetComponent(typeof(Event))); //IsContext = False IsNew = False
					if(StoredVariable234 != null)
					{
						UnityEngine.GameObject prop235 = StoredVariable234.Context; //IsContext = False IsNew = False
						if(prop235 != null)
						{
							Blackboards.cultist StoredVariable236 = ((Blackboards.cultist)prop235.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
							if(StoredVariable236 != null)
							{
								System.Single prop237 = StoredVariable236.Power; //IsContext = False IsNew = False
								OperandVar238 = prop237;
							}
						}
					}
				}
			}
			System.Boolean cult_won = ( (( (( ( (OperandVar227))) + ( ( (OperandVar231))))) * ( (0.05f)))) < ( ( (OperandVar238))); //IsContext = False IsNew = False
			System.Boolean OperandVar239 = default(System.Boolean); //IsContext = False IsNew = False
			OperandVar239 = cult_won;
			if( (OperandVar239))
			{
				UnityEngine.GameObject OperandVar241 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
				if(StoredVariable223 != null)
				{
					UnityEngine.GameObject prop240 = StoredVariable223.Context; //IsContext = False IsNew = False
					if(prop240 != null)
					{
						OperandVar241 = prop240;
					}
				}
				External.Destroy((UnityEngine.Object)( (OperandVar241)));
				UnityEngine.GameObject OperandVar243 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
				if(StoredVariable232 != null)
				{
					UnityEngine.GameObject prop242 = StoredVariable232.TargetRitual; //IsContext = False IsNew = False
					if(prop242 != null)
					{
						OperandVar243 = prop242;
					}
				}
				External.Regenerate((UnityEngine.GameObject)( (OperandVar243)));
				
				System.String OperandVar247 = default(System.String); //IsContext = False IsNew = False
				if(StoredVariable223 != null)
				{
					UnityEngine.GameObject prop244 = StoredVariable223.Context; //IsContext = False IsNew = False
					if(prop244 != null)
					{
						Named StoredVariable245 = ((Named)prop244.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable245 != null)
						{
							System.String prop246 = StoredVariable245.FullName; //IsContext = False IsNew = False
							if(prop246 != null)
							{
								OperandVar247 = prop246;
							}
						}
					}
				}
				
				
				External.Notify((( ( (OperandVar247))) + ( ( (" has been killed during the attempt to interrupt the ritual")))).ToString());
			}
			System.Boolean OperandVar248 = default(System.Boolean); //IsContext = False IsNew = False
			OperandVar248 = cult_won;
			if(!(OperandVar248))
			{
				
				{
					Blackboards.interrupt_ritual_attempt subContext249 = (Blackboards.interrupt_ritual_attempt)root.GetComponent(typeof(Blackboards.interrupt_ritual_attempt)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.interrupt_ritual_attempt subContext249 ContextSwitchInterpreter
					if(subContext249 != null)
					{
						
						
						{
							UnityEngine.GameObject subContext250 = subContext249.TargetRitual; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.GameObject subContext250 ContextPropertySwitchInterpreter
							if(subContext250 != null)
							{
								
								{
									Event subContext251 = (Event)subContext250.GetComponent(typeof(Event)); //IsContext = True IsNew = False
									//ContextStatement Event subContext251 ContextSwitchInterpreter
									if(subContext251 != null)
									{
										
										UnityEngine.GameObject OperandVar253 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										UnityEngine.GameObject prop252 = subContext251.Context; //IsContext = False IsNew = False
										if(prop252 != null)
										{
											OperandVar253 = prop252;
										}
										External.Destroy((UnityEngine.Object)( (OperandVar253)));
										
										
										
										System.String OperandVar257 = default(System.String); //IsContext = False IsNew = False
										UnityEngine.GameObject prop254 = subContext251.Context; //IsContext = False IsNew = False
										if(prop254 != null)
										{
											Named StoredVariable255 = ((Named)prop254.GetComponent(typeof(Named))); //IsContext = False IsNew = False
											if(StoredVariable255 != null)
											{
												System.String prop256 = StoredVariable255.FullName; //IsContext = False IsNew = False
												if(prop256 != null)
												{
													OperandVar257 = prop256;
												}
											}
										}
										External.Notify((( ( ("sucessfully interrupted the ritual and killed the cultist "))) + ( ( (OperandVar257)))).ToString());
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class ritual_watched : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar265 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable258 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable258 != null)
			{
				Blackboards.watch_for_the_ritual StoredVariable259 = ((Blackboards.watch_for_the_ritual)StoredVariable258.GetComponent(typeof(Blackboards.watch_for_the_ritual))); //IsContext = False IsNew = False
				if(StoredVariable259 != null)
				{
					System.Boolean ifResult260; //IsContext = False IsNew = False
					System.Boolean OperandVar264 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar262 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable258 != null)
					{
						UnityEngine.GameObject prop261 = StoredVariable258.Context; //IsContext = False IsNew = False
						if(prop261 != null)
						{
							OperandVar262 = prop261;
						}
					}
					System.Boolean prop263 = External.Has( (OperandVar262)); //IsContext = False IsNew = False
					OperandVar264 = prop263;
					if(ifResult260 =  (OperandVar264))
					{
						applicable = true;
						OperandVar265 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar265);
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
			
			
			
			
			System.Int32 OperandVar270 = default(System.Int32); //IsContext = False IsNew = False
			Event StoredVariable266 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable266 != null)
			{
				UnityEngine.GameObject prop267 = StoredVariable266.Context; //IsContext = False IsNew = False
				if(prop267 != null)
				{
					Blackboards.attributes StoredVariable268 = ((Blackboards.attributes)prop267.GetComponent(typeof(Blackboards.attributes))); //IsContext = False IsNew = False
					if(StoredVariable268 != null)
					{
						System.Int32 prop269 = StoredVariable268.Intellect; //IsContext = False IsNew = False
						OperandVar270 = prop269;
					}
				}
			}
			
			System.Int32 OperandVar274 = default(System.Int32); //IsContext = False IsNew = False
			if(StoredVariable266 != null)
			{
				UnityEngine.GameObject prop271 = StoredVariable266.Context; //IsContext = False IsNew = False
				if(prop271 != null)
				{
					Blackboards.attributes StoredVariable272 = ((Blackboards.attributes)prop271.GetComponent(typeof(Blackboards.attributes))); //IsContext = False IsNew = False
					if(StoredVariable272 != null)
					{
						System.Int32 prop273 = StoredVariable272.Mental; //IsContext = False IsNew = False
						OperandVar274 = prop273;
					}
				}
			}
			
			
			System.Single OperandVar281 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.interrupt_ritual_attempt StoredVariable275 = ((Blackboards.interrupt_ritual_attempt)root.GetComponent(typeof(Blackboards.interrupt_ritual_attempt))); //IsContext = False IsNew = False
			if(StoredVariable275 != null)
			{
				UnityEngine.GameObject prop276 = StoredVariable275.TargetRitual; //IsContext = False IsNew = False
				if(prop276 != null)
				{
					Event StoredVariable277 = ((Event)prop276.GetComponent(typeof(Event))); //IsContext = False IsNew = False
					if(StoredVariable277 != null)
					{
						UnityEngine.GameObject prop278 = StoredVariable277.Context; //IsContext = False IsNew = False
						if(prop278 != null)
						{
							Blackboards.cultist StoredVariable279 = ((Blackboards.cultist)prop278.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
							if(StoredVariable279 != null)
							{
								System.Single prop280 = StoredVariable279.Power; //IsContext = False IsNew = False
								OperandVar281 = prop280;
							}
						}
					}
				}
			}
			if(( (( (( ( (OperandVar270))) + ( ( (OperandVar274))))) * ( (0.05f)))) > ( ( (OperandVar281))))
			{
				
				
				
				System.String OperandVar288 = default(System.String); //IsContext = False IsNew = False
				Blackboards.watch_for_the_ritual StoredVariable282 = ((Blackboards.watch_for_the_ritual)root.GetComponent(typeof(Blackboards.watch_for_the_ritual))); //IsContext = False IsNew = False
				if(StoredVariable282 != null)
				{
					UnityEngine.GameObject prop283 = StoredVariable282.TargetRitual; //IsContext = False IsNew = False
					if(prop283 != null)
					{
						Event StoredVariable284 = ((Event)prop283.GetComponent(typeof(Event))); //IsContext = False IsNew = False
						if(StoredVariable284 != null)
						{
							UnityEngine.GameObject prop285 = StoredVariable284.Context; //IsContext = False IsNew = False
							if(prop285 != null)
							{
								Named StoredVariable286 = ((Named)prop285.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable286 != null)
								{
									System.String prop287 = StoredVariable286.FullName; //IsContext = False IsNew = False
									if(prop287 != null)
									{
										OperandVar288 = prop287;
									}
								}
							}
						}
					}
				}
				External.Notify((( ( ("The cultist is no less then the "))) + ( ( (OperandVar288)))).ToString());
			}
			
			{
				Blackboards.watch_for_the_ritual subContext289 = (Blackboards.watch_for_the_ritual)root.GetComponent(typeof(Blackboards.watch_for_the_ritual)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.watch_for_the_ritual subContext289 ContextSwitchInterpreter
				if(subContext289 != null)
				{
					
					UnityEngine.GameObject OperandVar291 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop290 = subContext289.TargetRitual; //IsContext = False IsNew = False
					if(prop290 != null)
					{
						OperandVar291 = prop290;
					}
					External.Regenerate((UnityEngine.GameObject)( (OperandVar291)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class gain_knowledge : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar298 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable292 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable292 != null)
			{
				Blackboards.noble StoredVariable293 = ((Blackboards.noble)StoredVariable292.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable293 != null)
				{
					Blackboards.cultist StoredVariable294 = ((Blackboards.cultist)StoredVariable293.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
					if(StoredVariable294 != null)
					{
						System.Boolean ifResult295; //IsContext = False IsNew = False
						System.Boolean OperandVar297 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable292 != null)
						{
							System.Boolean prop296 = StoredVariable292.IsActive; //IsContext = False IsNew = False
							OperandVar297 = prop296;
						}
						if(ifResult295 =  (OperandVar297))
						{
							applicable = true;
							OperandVar298 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar298);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar301 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable299 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable299 != null)
			{
				System.Single prop300 = StoredVariable299.Knowledge; //IsContext = False IsNew = False
				OperandVar301 = prop300;
			}
			return (System.Single)( ( (1f))) - ( ( (OperandVar301)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.noble subContext302 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext302 ContextSwitchInterpreter
				if(subContext302 != null)
				{
					
					
					System.Single OperandVar304 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop303 = subContext302.Knowledge; //IsContext = False IsNew = False
					OperandVar304 = prop303;
					
					
					subContext302.Knowledge = (System.Single)(( ( (OperandVar304))) + ( ( (0.05f))));
				}
			}
			UnityEngine.GameObject learn = new UnityEngine.GameObject("learn"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject learn305 = learn; //IsContext = True IsNew = False
				Event AddContext306 = (Event)learn.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext306 ContextSwitchInterpreter
					if(AddContext306 != null)
					{
						
						UnityEngine.GameObject OperandVar307 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar307 = root;
						AddContext306.Context = (UnityEngine.GameObject)( (OperandVar307));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(learn, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_ritual_performed : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar317 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable308 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable308 != null)
			{
				Blackboards.ritual StoredVariable309 = ((Blackboards.ritual)StoredVariable308.GetComponent(typeof(Blackboards.ritual))); //IsContext = False IsNew = False
				if(StoredVariable309 != null)
				{
					System.Boolean ifResult310; //IsContext = False IsNew = False
					
					System.Collections.Generic.List<Agent> OperandVar316 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					if(StoredVariable308 != null)
					{
						UnityEngine.GameObject prop311 = StoredVariable308.Context; //IsContext = False IsNew = False
						if(prop311 != null)
						{
							Blackboards.noble StoredVariable312 = ((Blackboards.noble)prop311.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
							if(StoredVariable312 != null)
							{
								UnityEngine.GameObject prop313 = StoredVariable312.Where; //IsContext = False IsNew = False
								if(prop313 != null)
								{
									Place StoredVariable314 = ((Place)prop313.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable314 != null)
									{
										System.Collections.Generic.List<Agent> prop315 = StoredVariable314.Agents; //IsContext = False IsNew = False
										if(prop315 != null)
										{
											OperandVar316 = prop315;
										}
									}
								}
							}
						}
					}
					
					
					if(ifResult310 = ( ( (OperandVar316 != null ? OperandVar316.Count : 0))) > ( ( (0f))))
					{
						applicable = true;
						OperandVar317 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar317);
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
				Blackboards.ritual subContext318 = (Blackboards.ritual)root.GetComponent(typeof(Blackboards.ritual)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ritual subContext318 ContextSwitchInterpreter
				if(subContext318 != null)
				{
					
					
					subContext318.Interrupted = (System.Boolean)( (true));
				}
			}
			UnityEngine.GameObject interruption_encounter = new UnityEngine.GameObject("interruption_encounter"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject interruption_encounter319 = interruption_encounter; //IsContext = True IsNew = False
				Entity AddContext320 = (Entity)interruption_encounter.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Encounter AddContext321 = (Encounter)interruption_encounter.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				Markers AddContext322 = (Markers)interruption_encounter.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Named AddContext323 = (Named)interruption_encounter.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext323 ContextSwitchInterpreter
					if(AddContext323 != null)
					{
						
						System.String OperandVar324 = default(System.String); //IsContext = False IsNew = False
						OperandVar324 = "main_name";
						
						
						AddContext323.Set(( (OperandVar324)).ToString(),(System.Single)( (0f)),( ("Ritual spotted!")).ToString());
					}
				}
				Blackboards.interrupt_event AddContext325 = (Blackboards.interrupt_event)interruption_encounter.AddComponent(typeof(Blackboards.interrupt_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.interrupt_event AddContext325 ContextSwitchInterpreter
					if(AddContext325 != null)
					{
						
						UnityEngine.GameObject OperandVar326 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar326 = root;
						AddContext325.TargetRitual = (UnityEngine.GameObject)( (OperandVar326));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(interruption_encounter, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class option_interrupt_ritual : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar329 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable327 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable327 != null)
			{
				Blackboards.interrupt_event StoredVariable328 = ((Blackboards.interrupt_event)StoredVariable327.GetComponent(typeof(Blackboards.interrupt_event))); //IsContext = False IsNew = False
				if(StoredVariable328 != null)
				{
					applicable = true;
					OperandVar329 = applicable;
				}
			}
			return (System.Boolean) (OperandVar329);
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
			
			
			External.Log((System.Object)( ("interrupt option")));
			
			{
				Blackboards.interrupt_event subContext330 = (Blackboards.interrupt_event)root.GetComponent(typeof(Blackboards.interrupt_event)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.interrupt_event subContext330 ContextSwitchInterpreter
				if(subContext330 != null)
				{
					
					
					{
						UnityEngine.GameObject subContext331 = subContext330.TargetRitual; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext331 ContextPropertySwitchInterpreter
						if(subContext331 != null)
						{
							
							{
								Event subContext332 = (Event)subContext331.GetComponent(typeof(Event)); //IsContext = True IsNew = False
								//ContextStatement Event subContext332 ContextSwitchInterpreter
								if(subContext332 != null)
								{
									
									
									{
										UnityEngine.GameObject subContext333 = subContext332.Context; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext333 ContextPropertySwitchInterpreter
										if(subContext333 != null)
										{
											
											{
												Blackboards.noble subContext334 = (Blackboards.noble)subContext333.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
												//ContextStatement Blackboards.noble subContext334 ContextSwitchInterpreter
												if(subContext334 != null)
												{
													
													
													{
														UnityEngine.GameObject subContext335 = subContext334.Where; //IsContext = True IsNew = False
														//ContextStatement UnityEngine.GameObject subContext335 ContextPropertySwitchInterpreter
														if(subContext335 != null)
														{
															
															{
																Place subContext336 = (Place)subContext335.GetComponent(typeof(Place)); //IsContext = True IsNew = False
																//ContextStatement Place subContext336 ContextSwitchInterpreter
																if(subContext336 != null)
																{
																	
																	for (int i337 = 0; subContext336.Agents != null && i337 < subContext336.Agents.Count; i337++)
																	{
																		Agent iter338 = subContext336.Agents[i337]; //IsContext = True IsNew = True
																		
																		{
																			//ContextStatement Agent iter338 ContextSwitchInterpreter
																			if(iter338 != null)
																			{
																				
																				UnityEngine.GameObject OperandVar341 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																				Agent OperandVar339 = default(Agent); //IsContext = False IsNew = False
																				OperandVar339 = iter338;
																				UnityEngine.GameObject prop340 = External.Gameobject( (OperandVar339)); //IsContext = False IsNew = False
																				if(prop340 != null)
																				{
																					OperandVar341 = prop340;
																				}
																				UnityEngine.GameObject go =  (OperandVar341); //IsContext = False IsNew = False
																				
																				{
																					//ContextStatement UnityEngine.GameObject go ContextSwitchInterpreter
																					if(go != null)
																					{
																						
																						
																						{
																							Blackboards.focused_ritual subContext342 = (Blackboards.focused_ritual)go.GetComponent(typeof(Blackboards.focused_ritual)); //IsContext = True IsNew = False
																							//ContextStatement Blackboards.focused_ritual subContext342 ContextSwitchInterpreter
																							if(subContext342 != null)
																							{
																								
																								System.Boolean OperandVar346 = default(System.Boolean); //IsContext = False IsNew = False
																								UnityEngine.GameObject OperandVar344 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																								UnityEngine.GameObject prop343 = subContext342.Focus; //IsContext = False IsNew = False
																								if(prop343 != null)
																								{
																									OperandVar344 = prop343;
																								}
																								System.Boolean prop345 = External.Has( (OperandVar344)); //IsContext = False IsNew = False
																								OperandVar346 = prop345;
																								if(!(OperandVar346))
																								{
																									UnityEngine.GameObject OperandVar349 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																									Blackboards.focused_ritual OperandVar347 = default(Blackboards.focused_ritual); //IsContext = False IsNew = False
																									OperandVar347 = subContext342;
																									UnityEngine.GameObject prop348 = External.Gameobject( (OperandVar347)); //IsContext = False IsNew = False
																									if(prop348 != null)
																									{
																										OperandVar349 = prop348;
																									}
																									UnityEngine.GameObject ag =  (OperandVar349); //IsContext = False IsNew = False
																									UnityEngine.GameObject interrupt_proto = new UnityEngine.GameObject("interrupt_proto"); //IsContext = False IsNew = False
																									
																									{
																										UnityEngine.GameObject interrupt_proto350 = interrupt_proto; //IsContext = True IsNew = False
																										Entity AddContext351 = (Entity)interrupt_proto.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
																										Event AddContext352 = (Event)interrupt_proto.AddComponent(typeof(Event)); //IsContext = True IsNew = True
																										
																										{
																											//ContextStatement Event AddContext352 ContextSwitchInterpreter
																											if(AddContext352 != null)
																											{
																												
																												UnityEngine.GameObject OperandVar353 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																												OperandVar353 = ag;
																												AddContext352.Context = (UnityEngine.GameObject)( (OperandVar353));
																											}
																										}
																										Blackboards.interrupt_ritual_attempt AddContext354 = (Blackboards.interrupt_ritual_attempt)interrupt_proto.AddComponent(typeof(Blackboards.interrupt_ritual_attempt)); //IsContext = True IsNew = True
																										
																										{
																											//ContextStatement Blackboards.interrupt_ritual_attempt AddContext354 ContextSwitchInterpreter
																											if(AddContext354 != null)
																											{
																												
																												UnityEngine.GameObject OperandVar357 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																												Blackboards.interrupt_event StoredVariable355 = ((Blackboards.interrupt_event)root.GetComponent(typeof(Blackboards.interrupt_event))); //IsContext = False IsNew = False
																												if(StoredVariable355 != null)
																												{
																													UnityEngine.GameObject prop356 = StoredVariable355.TargetRitual; //IsContext = False IsNew = False
																													if(prop356 != null)
																													{
																														OperandVar357 = prop356;
																													}
																												}
																												AddContext354.TargetRitual = (UnityEngine.GameObject)( (OperandVar357));
																											}
																										}
																										Named AddContext358 = (Named)interrupt_proto.AddComponent(typeof(Named)); //IsContext = True IsNew = True
																										
																										{
																											//ContextStatement Named AddContext358 ContextSwitchInterpreter
																											if(AddContext358 != null)
																											{
																												
																												System.String OperandVar359 = default(System.String); //IsContext = False IsNew = False
																												OperandVar359 = "main_name";
																												
																												
																												AddContext358.Set(( (OperandVar359)).ToString(),(System.Single)( (0f)),( ("try to interrupt! ")).ToString());
																												System.String OperandVar360 = default(System.String); //IsContext = False IsNew = False
																												OperandVar360 = "who";
																												
																												System.String OperandVar364 = default(System.String); //IsContext = False IsNew = False
																												Named StoredVariable361 = ((Named)ag.GetComponent(typeof(Named))); //IsContext = False IsNew = False
																												if(StoredVariable361 != null)
																												{
																													System.String OperandVar362 = default(System.String); //IsContext = False IsNew = False
																													OperandVar362 = "main_name";
																													System.String prop363 = StoredVariable361.Get( (OperandVar362)); //IsContext = False IsNew = False
																													if(prop363 != null)
																													{
																														OperandVar364 = prop363;
																													}
																												}
																												AddContext358.Set(( (OperandVar360)).ToString(),(System.Single)( (1f)),( (OperandVar364)).ToString());
																											}
																										}
																									}
																									UnityEngine.GameObject OperandVar367 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																									Blackboards.interrupt_event StoredVariable365 = ((Blackboards.interrupt_event)root.GetComponent(typeof(Blackboards.interrupt_event))); //IsContext = False IsNew = False
																									if(StoredVariable365 != null)
																									{
																										UnityEngine.GameObject prop366 = StoredVariable365.TargetRitual; //IsContext = False IsNew = False
																										if(prop366 != null)
																										{
																											OperandVar367 = prop366;
																										}
																									}
																									subContext342.Focus = (UnityEngine.GameObject)( (OperandVar367));
																									
																									{
																										//ContextStatement UnityEngine.GameObject root ContextSwitchInterpreter
																										if(root != null)
																										{
																											
																											
																											{
																												Encounter subContext368 = (Encounter)root.GetComponent(typeof(Encounter)); //IsContext = True IsNew = False
																												//ContextStatement Encounter subContext368 ContextSwitchInterpreter
																												if(subContext368 != null)
																												{
																													
																													UnityEngine.GameObject OperandVar369 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																													OperandVar369 = interrupt_proto;
																													subContext368.Option((UnityEngine.GameObject)( (OperandVar369)));
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
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class option_watch_for_the_ritual : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar372 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable370 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable370 != null)
			{
				Blackboards.interrupt_event StoredVariable371 = ((Blackboards.interrupt_event)StoredVariable370.GetComponent(typeof(Blackboards.interrupt_event))); //IsContext = False IsNew = False
				if(StoredVariable371 != null)
				{
					applicable = true;
					OperandVar372 = applicable;
				}
			}
			return (System.Boolean) (OperandVar372);
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
			
			
			External.Log((System.Object)( ("watch option")));
			
			{
				Blackboards.interrupt_event subContext373 = (Blackboards.interrupt_event)root.GetComponent(typeof(Blackboards.interrupt_event)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.interrupt_event subContext373 ContextSwitchInterpreter
				if(subContext373 != null)
				{
					
					
					{
						UnityEngine.GameObject subContext374 = subContext373.TargetRitual; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext374 ContextPropertySwitchInterpreter
						if(subContext374 != null)
						{
							
							{
								Event subContext375 = (Event)subContext374.GetComponent(typeof(Event)); //IsContext = True IsNew = False
								//ContextStatement Event subContext375 ContextSwitchInterpreter
								if(subContext375 != null)
								{
									
									
									{
										UnityEngine.GameObject subContext376 = subContext375.Context; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext376 ContextPropertySwitchInterpreter
										if(subContext376 != null)
										{
											
											{
												Blackboards.noble subContext377 = (Blackboards.noble)subContext376.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
												//ContextStatement Blackboards.noble subContext377 ContextSwitchInterpreter
												if(subContext377 != null)
												{
													
													
													{
														UnityEngine.GameObject subContext378 = subContext377.Where; //IsContext = True IsNew = False
														//ContextStatement UnityEngine.GameObject subContext378 ContextPropertySwitchInterpreter
														if(subContext378 != null)
														{
															
															{
																Place subContext379 = (Place)subContext378.GetComponent(typeof(Place)); //IsContext = True IsNew = False
																//ContextStatement Place subContext379 ContextSwitchInterpreter
																if(subContext379 != null)
																{
																	
																	for (int i380 = 0; subContext379.Agents != null && i380 < subContext379.Agents.Count; i380++)
																	{
																		Agent iter381 = subContext379.Agents[i380]; //IsContext = True IsNew = True
																		
																		{
																			//ContextStatement Agent iter381 ContextSwitchInterpreter
																			if(iter381 != null)
																			{
																				
																				UnityEngine.GameObject OperandVar384 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																				Agent OperandVar382 = default(Agent); //IsContext = False IsNew = False
																				OperandVar382 = iter381;
																				UnityEngine.GameObject prop383 = External.Gameobject( (OperandVar382)); //IsContext = False IsNew = False
																				if(prop383 != null)
																				{
																					OperandVar384 = prop383;
																				}
																				UnityEngine.GameObject go =  (OperandVar384); //IsContext = False IsNew = False
																				
																				{
																					//ContextStatement UnityEngine.GameObject go ContextSwitchInterpreter
																					if(go != null)
																					{
																						
																						
																						{
																							Blackboards.focused_ritual subContext385 = (Blackboards.focused_ritual)go.GetComponent(typeof(Blackboards.focused_ritual)); //IsContext = True IsNew = False
																							//ContextStatement Blackboards.focused_ritual subContext385 ContextSwitchInterpreter
																							if(subContext385 != null)
																							{
																								
																								System.Boolean OperandVar389 = default(System.Boolean); //IsContext = False IsNew = False
																								UnityEngine.GameObject OperandVar387 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																								UnityEngine.GameObject prop386 = subContext385.Focus; //IsContext = False IsNew = False
																								if(prop386 != null)
																								{
																									OperandVar387 = prop386;
																								}
																								System.Boolean prop388 = External.Has( (OperandVar387)); //IsContext = False IsNew = False
																								OperandVar389 = prop388;
																								if(!(OperandVar389))
																								{
																									UnityEngine.GameObject OperandVar392 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																									Blackboards.focused_ritual OperandVar390 = default(Blackboards.focused_ritual); //IsContext = False IsNew = False
																									OperandVar390 = subContext385;
																									UnityEngine.GameObject prop391 = External.Gameobject( (OperandVar390)); //IsContext = False IsNew = False
																									if(prop391 != null)
																									{
																										OperandVar392 = prop391;
																									}
																									UnityEngine.GameObject ag =  (OperandVar392); //IsContext = False IsNew = False
																									UnityEngine.GameObject watch_proto = new UnityEngine.GameObject("watch_proto"); //IsContext = False IsNew = False
																									
																									{
																										UnityEngine.GameObject watch_proto393 = watch_proto; //IsContext = True IsNew = False
																										Entity AddContext394 = (Entity)watch_proto.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
																										Event AddContext395 = (Event)watch_proto.AddComponent(typeof(Event)); //IsContext = True IsNew = True
																										
																										{
																											//ContextStatement Event AddContext395 ContextSwitchInterpreter
																											if(AddContext395 != null)
																											{
																												
																												UnityEngine.GameObject OperandVar396 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																												OperandVar396 = ag;
																												AddContext395.Context = (UnityEngine.GameObject)( (OperandVar396));
																											}
																										}
																										Blackboards.watch_for_the_ritual AddContext397 = (Blackboards.watch_for_the_ritual)watch_proto.AddComponent(typeof(Blackboards.watch_for_the_ritual)); //IsContext = True IsNew = True
																										
																										{
																											//ContextStatement Blackboards.watch_for_the_ritual AddContext397 ContextSwitchInterpreter
																											if(AddContext397 != null)
																											{
																												
																												UnityEngine.GameObject OperandVar400 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																												Blackboards.interrupt_event StoredVariable398 = ((Blackboards.interrupt_event)root.GetComponent(typeof(Blackboards.interrupt_event))); //IsContext = False IsNew = False
																												if(StoredVariable398 != null)
																												{
																													UnityEngine.GameObject prop399 = StoredVariable398.TargetRitual; //IsContext = False IsNew = False
																													if(prop399 != null)
																													{
																														OperandVar400 = prop399;
																													}
																												}
																												AddContext397.TargetRitual = (UnityEngine.GameObject)( (OperandVar400));
																											}
																										}
																										Named AddContext401 = (Named)watch_proto.AddComponent(typeof(Named)); //IsContext = True IsNew = True
																										
																										{
																											//ContextStatement Named AddContext401 ContextSwitchInterpreter
																											if(AddContext401 != null)
																											{
																												
																												System.String OperandVar402 = default(System.String); //IsContext = False IsNew = False
																												OperandVar402 = "main_name";
																												
																												
																												AddContext401.Set(( (OperandVar402)).ToString(),(System.Single)( (0f)),( ("try to watch! ")).ToString());
																												System.String OperandVar403 = default(System.String); //IsContext = False IsNew = False
																												OperandVar403 = "who";
																												
																												System.String OperandVar407 = default(System.String); //IsContext = False IsNew = False
																												Named StoredVariable404 = ((Named)ag.GetComponent(typeof(Named))); //IsContext = False IsNew = False
																												if(StoredVariable404 != null)
																												{
																													System.String OperandVar405 = default(System.String); //IsContext = False IsNew = False
																													OperandVar405 = "main_name";
																													System.String prop406 = StoredVariable404.Get( (OperandVar405)); //IsContext = False IsNew = False
																													if(prop406 != null)
																													{
																														OperandVar407 = prop406;
																													}
																												}
																												AddContext401.Set(( (OperandVar403)).ToString(),(System.Single)( (1f)),( (OperandVar407)).ToString());
																											}
																										}
																									}
																									UnityEngine.GameObject OperandVar410 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																									Blackboards.interrupt_event StoredVariable408 = ((Blackboards.interrupt_event)root.GetComponent(typeof(Blackboards.interrupt_event))); //IsContext = False IsNew = False
																									if(StoredVariable408 != null)
																									{
																										UnityEngine.GameObject prop409 = StoredVariable408.TargetRitual; //IsContext = False IsNew = False
																										if(prop409 != null)
																										{
																											OperandVar410 = prop409;
																										}
																									}
																									subContext385.Focus = (UnityEngine.GameObject)( (OperandVar410));
																									
																									{
																										//ContextStatement UnityEngine.GameObject root ContextSwitchInterpreter
																										if(root != null)
																										{
																											
																											
																											{
																												Encounter subContext411 = (Encounter)root.GetComponent(typeof(Encounter)); //IsContext = True IsNew = False
																												//ContextStatement Encounter subContext411 ContextSwitchInterpreter
																												if(subContext411 != null)
																												{
																													
																													UnityEngine.GameObject OperandVar412 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
																													OperandVar412 = watch_proto;
																													subContext411.Option((UnityEngine.GameObject)( (OperandVar412)));
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
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class common_noble : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar420 = default(System.Boolean); //IsContext = False IsNew = False
			Interactables StoredVariable413 = ((Interactables)root.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
			if(StoredVariable413 != null)
			{
				Blackboards.city StoredVariable414 = ((Blackboards.city)StoredVariable413.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
				if(StoredVariable414 != null)
				{
					System.Boolean ifResult415; //IsContext = False IsNew = False
					
					System.Int32 OperandVar417 = default(System.Int32); //IsContext = False IsNew = False
					if(StoredVariable413 != null)
					{
						System.Int32 prop416 = StoredVariable413.Count; //IsContext = False IsNew = False
						OperandVar417 = prop416;
					}
					
					System.Int32 OperandVar419 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop418 = StoredVariable414.Size; //IsContext = False IsNew = False
					OperandVar419 = prop418;
					if(ifResult415 = ( ( (OperandVar417))) < ( ( (OperandVar419))))
					{
						applicable = true;
						OperandVar420 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar420);
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
			
			UnityEngine.GameObject noble_obj = new UnityEngine.GameObject("noble_obj"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject noble_obj421 = noble_obj; //IsContext = True IsNew = False
				Actor AddContext422 = (Actor)noble_obj.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Entity AddContext423 = (Entity)noble_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext424 = (Markers)noble_obj.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Blackboards.personality AddContext425 = (Blackboards.personality)noble_obj.AddComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = True
				Interactable AddContext426 = (Interactable)noble_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
				Blackboards.noble AddContext427 = (Blackboards.noble)noble_obj.AddComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.noble AddContext427 ContextSwitchInterpreter
					if(AddContext427 != null)
					{
						
						UnityEngine.GameObject OperandVar430 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.city StoredVariable428 = ((Blackboards.city)root.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
						if(StoredVariable428 != null)
						{
							UnityEngine.GameObject prop429 = StoredVariable428.Of; //IsContext = False IsNew = False
							if(prop429 != null)
							{
								OperandVar430 = prop429;
							}
						}
						AddContext427.Of = (UnityEngine.GameObject)( (OperandVar430));
						UnityEngine.GameObject OperandVar431 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar431 = root;
						AddContext427.Where = (UnityEngine.GameObject)( (OperandVar431));
					}
				}
				Named AddContext432 = (Named)noble_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext432 ContextSwitchInterpreter
					if(AddContext432 != null)
					{
						
						System.String OperandVar433 = default(System.String); //IsContext = False IsNew = False
						OperandVar433 = "main_name";
						
						System.String OperandVar436 = default(System.String); //IsContext = False IsNew = False
						System.String OperandVar434 = default(System.String); //IsContext = False IsNew = False
						OperandVar434 = "human_name";
						System.String prop435 = External.RandomName( (OperandVar434)); //IsContext = False IsNew = False
						if(prop435 != null)
						{
							OperandVar436 = prop435;
						}
						AddContext432.Set(( (OperandVar433)).ToString(),(System.Single)( (0f)),( (OperandVar436)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(noble_obj, 0.1f);
			
			{
				Interactables subContext437 = (Interactables)root.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
				//ContextStatement Interactables subContext437 ContextSwitchInterpreter
				if(subContext437 != null)
				{
					
					UnityEngine.GameObject OperandVar438 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar438 = noble_obj;
					subContext437.Attach((UnityEngine.GameObject)( (OperandVar438)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_emperor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar453 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable439 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable439 != null)
			{
				Named StoredVariable440 = ((Named)StoredVariable439.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable440 != null)
				{
					System.Boolean ifResult441; //IsContext = False IsNew = False
					
					Blackboards.country OperandVar444 = default(Blackboards.country); //IsContext = False IsNew = False
					if(StoredVariable439 != null)
					{
						UnityEngine.GameObject prop442 = StoredVariable439.Of; //IsContext = False IsNew = False
						if(prop442 != null)
						{
							Blackboards.country StoredVariable443 = ((Blackboards.country)prop442.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable443 != null)
							{
								OperandVar444 = StoredVariable443;
							}
						}
					}
					
					System.Boolean OperandVar452 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable439 != null)
					{
						UnityEngine.GameObject prop445 = StoredVariable439.Of; //IsContext = False IsNew = False
						if(prop445 != null)
						{
							Blackboards.country StoredVariable446 = ((Blackboards.country)prop445.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable446 != null)
							{
								System.Boolean ifResult447; //IsContext = False IsNew = False
								System.Boolean OperandVar451 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject OperandVar449 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								UnityEngine.GameObject prop448 = StoredVariable446.Emperor; //IsContext = False IsNew = False
								if(prop448 != null)
								{
									OperandVar449 = prop448;
								}
								System.Boolean prop450 = External.Has( (OperandVar449)); //IsContext = False IsNew = False
								OperandVar451 = prop450;
								if(ifResult447 = !(OperandVar451))
								{
									OperandVar452 = ifResult447;
								}
							}
						}
					}
					if(ifResult441 = ( ( (OperandVar444))) && ( ( (OperandVar452))))
					{
						applicable = true;
						OperandVar453 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar453);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (10f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext454 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext454 ContextSwitchInterpreter
				if(subContext454 != null)
				{
					
					System.String OperandVar455 = default(System.String); //IsContext = False IsNew = False
					OperandVar455 = "postfix";
					
					
					subContext454.Set(( (OperandVar455)).ToString(),(System.Single)( (1f)),( (", the Emperor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext456 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext456 ContextSwitchInterpreter
				if(subContext456 != null)
				{
					
					System.Single OperandVar458 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop457 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar458 = prop457;
					subContext456.Loyalty = (System.Single)( (OperandVar458));
					System.Single OperandVar460 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop459 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar460 = prop459;
					subContext456.Sanity = (System.Single)( (OperandVar460));
					System.Single OperandVar462 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop461 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar462 = prop461;
					subContext456.Influence = (System.Single)( (OperandVar462));
					System.Single OperandVar464 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop463 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar464 = prop463;
					subContext456.Knowledge = (System.Single)( (OperandVar464));
					System.Single OperandVar466 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop465 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar466 = prop465;
					subContext456.Occult = (System.Single)( (OperandVar466));
				}
			}
			
			{
				Blackboards.noble subContext467 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext467 ContextSwitchInterpreter
				if(subContext467 != null)
				{
					
					
					{
						UnityEngine.GameObject subContext468 = subContext467.Of; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext468 ContextPropertySwitchInterpreter
						if(subContext468 != null)
						{
							
							{
								Blackboards.country subContext469 = (Blackboards.country)subContext468.GetComponent(typeof(Blackboards.country)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.country subContext469 ContextSwitchInterpreter
								if(subContext469 != null)
								{
									
									UnityEngine.GameObject OperandVar470 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar470 = root;
									subContext469.Emperor = (UnityEngine.GameObject)( (OperandVar470));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_inquisitor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar473 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable471 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable471 != null)
			{
				Named StoredVariable472 = ((Named)StoredVariable471.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable472 != null)
				{
					applicable = true;
					OperandVar473 = applicable;
				}
			}
			return (System.Boolean) (OperandVar473);
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
				Named subContext474 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext474 ContextSwitchInterpreter
				if(subContext474 != null)
				{
					
					System.String OperandVar475 = default(System.String); //IsContext = False IsNew = False
					OperandVar475 = "postfix";
					
					
					subContext474.Set(( (OperandVar475)).ToString(),(System.Single)( (1f)),( (", an inquisitor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext476 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext476 ContextSwitchInterpreter
				if(subContext476 != null)
				{
					
					System.Single OperandVar478 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop477 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar478 = prop477;
					subContext476.Loyalty = (System.Single)( (OperandVar478));
					System.Single OperandVar480 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop479 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar480 = prop479;
					subContext476.Sanity = (System.Single)( (OperandVar480));
					System.Single OperandVar482 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop481 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar482 = prop481;
					subContext476.Influence = (System.Single)( (OperandVar482));
					System.Single OperandVar484 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop483 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar484 = prop483;
					subContext476.Knowledge = (System.Single)( (OperandVar484));
					System.Single OperandVar486 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop485 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar486 = prop485;
					subContext476.Occult = (System.Single)( (OperandVar486));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_trader : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar489 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable487 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable487 != null)
			{
				Named StoredVariable488 = ((Named)StoredVariable487.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable488 != null)
				{
					applicable = true;
					OperandVar489 = applicable;
				}
			}
			return (System.Boolean) (OperandVar489);
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
				Named subContext490 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext490 ContextSwitchInterpreter
				if(subContext490 != null)
				{
					
					System.String OperandVar491 = default(System.String); //IsContext = False IsNew = False
					OperandVar491 = "postfix";
					
					
					subContext490.Set(( (OperandVar491)).ToString(),(System.Single)( (1f)),( (", a trader")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext492 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext492 ContextSwitchInterpreter
				if(subContext492 != null)
				{
					
					System.Single OperandVar494 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop493 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar494 = prop493;
					subContext492.Loyalty = (System.Single)( (OperandVar494));
					System.Single OperandVar496 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop495 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar496 = prop495;
					subContext492.Sanity = (System.Single)( (OperandVar496));
					System.Single OperandVar498 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop497 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar498 = prop497;
					subContext492.Influence = (System.Single)( (OperandVar498));
					System.Single OperandVar500 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop499 = External.Random( (0.4f), (0.5f)); //IsContext = False IsNew = False
					OperandVar500 = prop499;
					subContext492.Knowledge = (System.Single)( (OperandVar500));
					System.Single OperandVar502 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop501 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar502 = prop501;
					subContext492.Occult = (System.Single)( (OperandVar502));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_aristocrat : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar505 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable503 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable503 != null)
			{
				Named StoredVariable504 = ((Named)StoredVariable503.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable504 != null)
				{
					applicable = true;
					OperandVar505 = applicable;
				}
			}
			return (System.Boolean) (OperandVar505);
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
				Named subContext506 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext506 ContextSwitchInterpreter
				if(subContext506 != null)
				{
					
					System.String OperandVar507 = default(System.String); //IsContext = False IsNew = False
					OperandVar507 = "postfix";
					
					
					subContext506.Set(( (OperandVar507)).ToString(),(System.Single)( (1f)),( (", an aristocrat")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext508 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext508 ContextSwitchInterpreter
				if(subContext508 != null)
				{
					
					System.Single OperandVar510 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop509 = External.Random( (0.5f), (0.6f)); //IsContext = False IsNew = False
					OperandVar510 = prop509;
					subContext508.Loyalty = (System.Single)( (OperandVar510));
					System.Single OperandVar512 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop511 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar512 = prop511;
					subContext508.Sanity = (System.Single)( (OperandVar512));
					System.Single OperandVar514 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop513 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar514 = prop513;
					subContext508.Influence = (System.Single)( (OperandVar514));
					System.Single OperandVar516 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop515 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar516 = prop515;
					subContext508.Knowledge = (System.Single)( (OperandVar516));
					System.Single OperandVar518 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop517 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar518 = prop517;
					subContext508.Occult = (System.Single)( (OperandVar518));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_governor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar521 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable519 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable519 != null)
			{
				Named StoredVariable520 = ((Named)StoredVariable519.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable520 != null)
				{
					applicable = true;
					OperandVar521 = applicable;
				}
			}
			return (System.Boolean) (OperandVar521);
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
				Named subContext522 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext522 ContextSwitchInterpreter
				if(subContext522 != null)
				{
					
					System.String OperandVar523 = default(System.String); //IsContext = False IsNew = False
					OperandVar523 = "postfix";
					
					
					subContext522.Set(( (OperandVar523)).ToString(),(System.Single)( (1f)),( (", a governor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext524 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext524 ContextSwitchInterpreter
				if(subContext524 != null)
				{
					
					System.Single OperandVar526 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop525 = External.Random( (0.2f), (0.6f)); //IsContext = False IsNew = False
					OperandVar526 = prop525;
					subContext524.Loyalty = (System.Single)( (OperandVar526));
					System.Single OperandVar528 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop527 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar528 = prop527;
					subContext524.Sanity = (System.Single)( (OperandVar528));
					System.Single OperandVar530 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop529 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar530 = prop529;
					subContext524.Influence = (System.Single)( (OperandVar530));
					System.Single OperandVar532 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop531 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar532 = prop531;
					subContext524.Knowledge = (System.Single)( (OperandVar532));
					System.Single OperandVar534 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop533 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar534 = prop533;
					subContext524.Occult = (System.Single)( (OperandVar534));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_general : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar537 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable535 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable535 != null)
			{
				Named StoredVariable536 = ((Named)StoredVariable535.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable536 != null)
				{
					applicable = true;
					OperandVar537 = applicable;
				}
			}
			return (System.Boolean) (OperandVar537);
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
				Named subContext538 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext538 ContextSwitchInterpreter
				if(subContext538 != null)
				{
					
					System.String OperandVar539 = default(System.String); //IsContext = False IsNew = False
					OperandVar539 = "postfix";
					
					
					subContext538.Set(( (OperandVar539)).ToString(),(System.Single)( (1f)),( (", a general")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext540 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext540 ContextSwitchInterpreter
				if(subContext540 != null)
				{
					
					System.Single OperandVar542 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop541 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar542 = prop541;
					subContext540.Loyalty = (System.Single)( (OperandVar542));
					System.Single OperandVar544 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop543 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar544 = prop543;
					subContext540.Sanity = (System.Single)( (OperandVar544));
					System.Single OperandVar546 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop545 = External.Random( (0.3f), (0.4f)); //IsContext = False IsNew = False
					OperandVar546 = prop545;
					subContext540.Influence = (System.Single)( (OperandVar546));
					System.Single OperandVar548 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop547 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar548 = prop547;
					subContext540.Knowledge = (System.Single)( (OperandVar548));
					System.Single OperandVar550 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop549 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar550 = prop549;
					subContext540.Occult = (System.Single)( (OperandVar550));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_alchemist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar553 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable551 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable551 != null)
			{
				Named StoredVariable552 = ((Named)StoredVariable551.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable552 != null)
				{
					applicable = true;
					OperandVar553 = applicable;
				}
			}
			return (System.Boolean) (OperandVar553);
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
				Named subContext554 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext554 ContextSwitchInterpreter
				if(subContext554 != null)
				{
					
					System.String OperandVar555 = default(System.String); //IsContext = False IsNew = False
					OperandVar555 = "postfix";
					
					
					subContext554.Set(( (OperandVar555)).ToString(),(System.Single)( (1f)),( (", an alchemist")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext556 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext556 ContextSwitchInterpreter
				if(subContext556 != null)
				{
					
					System.Single OperandVar558 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop557 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar558 = prop557;
					subContext556.Loyalty = (System.Single)( (OperandVar558));
					System.Single OperandVar560 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop559 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar560 = prop559;
					subContext556.Sanity = (System.Single)( (OperandVar560));
					System.Single OperandVar562 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop561 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar562 = prop561;
					subContext556.Influence = (System.Single)( (OperandVar562));
					System.Single OperandVar564 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop563 = External.Random( (0.3f), (1f)); //IsContext = False IsNew = False
					OperandVar564 = prop563;
					subContext556.Knowledge = (System.Single)( (OperandVar564));
					System.Single OperandVar566 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop565 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar566 = prop565;
					subContext556.Occult = (System.Single)( (OperandVar566));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_mage : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar569 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable567 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable567 != null)
			{
				Named StoredVariable568 = ((Named)StoredVariable567.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable568 != null)
				{
					applicable = true;
					OperandVar569 = applicable;
				}
			}
			return (System.Boolean) (OperandVar569);
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
				Named subContext570 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext570 ContextSwitchInterpreter
				if(subContext570 != null)
				{
					
					System.String OperandVar571 = default(System.String); //IsContext = False IsNew = False
					OperandVar571 = "postfix";
					
					
					subContext570.Set(( (OperandVar571)).ToString(),(System.Single)( (1f)),( (", a mage")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext572 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext572 ContextSwitchInterpreter
				if(subContext572 != null)
				{
					
					System.Single OperandVar574 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop573 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar574 = prop573;
					subContext572.Loyalty = (System.Single)( (OperandVar574));
					System.Single OperandVar576 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop575 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar576 = prop575;
					subContext572.Sanity = (System.Single)( (OperandVar576));
					System.Single OperandVar578 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop577 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar578 = prop577;
					subContext572.Influence = (System.Single)( (OperandVar578));
					System.Single OperandVar580 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop579 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar580 = prop579;
					subContext572.Knowledge = (System.Single)( (OperandVar580));
					System.Single OperandVar582 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop581 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar582 = prop581;
					subContext572.Occult = (System.Single)( (OperandVar582));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_priest : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar585 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable583 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable583 != null)
			{
				Named StoredVariable584 = ((Named)StoredVariable583.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable584 != null)
				{
					applicable = true;
					OperandVar585 = applicable;
				}
			}
			return (System.Boolean) (OperandVar585);
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
				Named subContext586 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext586 ContextSwitchInterpreter
				if(subContext586 != null)
				{
					
					System.String OperandVar587 = default(System.String); //IsContext = False IsNew = False
					OperandVar587 = "postfix";
					
					
					subContext586.Set(( (OperandVar587)).ToString(),(System.Single)( (1f)),( (", a priest")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext588 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext588 ContextSwitchInterpreter
				if(subContext588 != null)
				{
					
					System.Single OperandVar590 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop589 = External.Random( (0.9f), (1f)); //IsContext = False IsNew = False
					OperandVar590 = prop589;
					subContext588.Loyalty = (System.Single)( (OperandVar590));
					System.Single OperandVar592 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop591 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar592 = prop591;
					subContext588.Sanity = (System.Single)( (OperandVar592));
					System.Single OperandVar594 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop593 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar594 = prop593;
					subContext588.Influence = (System.Single)( (OperandVar594));
					System.Single OperandVar596 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop595 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar596 = prop595;
					subContext588.Knowledge = (System.Single)( (OperandVar596));
					System.Single OperandVar598 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop597 = External.Random( (0f), (0f)); //IsContext = False IsNew = False
					OperandVar598 = prop597;
					subContext588.Occult = (System.Single)( (OperandVar598));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class travel : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar605 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable599 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable599 != null)
			{
				Blackboards.noble StoredVariable600 = ((Blackboards.noble)StoredVariable599.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable600 != null)
				{
					InteractablesMarker StoredVariable601 = ((InteractablesMarker)StoredVariable600.GetComponent(typeof(InteractablesMarker))); //IsContext = False IsNew = False
					if(StoredVariable601 != null)
					{
						System.Boolean ifResult602; //IsContext = False IsNew = False
						System.Boolean OperandVar604 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable599 != null)
						{
							System.Boolean prop603 = StoredVariable599.IsActive; //IsContext = False IsNew = False
							OperandVar604 = prop603;
						}
						if(ifResult602 =  (OperandVar604))
						{
							applicable = true;
							OperandVar605 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar605);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar608 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable606 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable606 != null)
			{
				System.Single prop607 = StoredVariable606.Influence; //IsContext = False IsNew = False
				OperandVar608 = prop607;
			}
			
			
			return (System.Single)( ( (OperandVar608))) - ( ( (0.8f)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				InteractablesMarker subContext609 = (InteractablesMarker)root.GetComponent(typeof(InteractablesMarker)); //IsContext = True IsNew = False
				//ContextStatement InteractablesMarker subContext609 ContextSwitchInterpreter
				if(subContext609 != null)
				{
					
					UnityEngine.GameObject OperandVar610 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar610 = root;
					UnityEngine.GameObject detach =  (OperandVar610); //IsContext = False IsNew = False
				}
			}
			UnityEngine.GameObject OperandVar624 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> OperandVar612 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> prop611 = External.AllActors; //IsContext = False IsNew = False
			if(prop611 != null)
			{
				OperandVar612 = prop611;
			}
			UnityEngine.GameObject prop623 = External.RandomFrom( (OperandVar612),(UnityEngine.GameObject go)=>{;
;
System.Boolean OperandVar616 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.city OperandVar614 = default(Blackboards.city); //IsContext = False IsNew = False;
Blackboards.city StoredVariable613 = ((Blackboards.city)go.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False;
if(StoredVariable613 != null)
				{
					OperandVar614 = StoredVariable613;
				};
System.Boolean prop615 = External.Has( (OperandVar614)); //IsContext = False IsNew = False;
OperandVar616 = prop615;;
;
System.Boolean OperandVar620 = default(System.Boolean); //IsContext = False IsNew = False;
Interactables OperandVar618 = default(Interactables); //IsContext = False IsNew = False;
Interactables StoredVariable617 = ((Interactables)go.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False;
if(StoredVariable617 != null)
				{
					OperandVar618 = StoredVariable617;
				};
System.Boolean prop619 = External.Has( (OperandVar618)); //IsContext = False IsNew = False;
OperandVar620 = prop619;;
;
;
;
UnityEngine.GameObject OperandVar621 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar621 = go;;
;
UnityEngine.GameObject OperandVar622 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar622 = root;;
return ( ( (OperandVar616))) && ( ( (OperandVar620))) && ( (!(( ( (OperandVar621))) == ( ( (OperandVar622))))));}); //IsContext = False IsNew = False
			if(prop623 != null)
			{
				OperandVar624 = prop623;
			}
			UnityEngine.GameObject another_city =  (OperandVar624); //IsContext = False IsNew = False
			System.Boolean OperandVar627 = default(System.Boolean); //IsContext = False IsNew = False
			UnityEngine.GameObject OperandVar625 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar625 = another_city;
			System.Boolean prop626 = External.Has( (OperandVar625)); //IsContext = False IsNew = False
			OperandVar627 = prop626;
			if( (OperandVar627))
			{
				
				{
					Blackboards.noble subContext628 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.noble subContext628 ContextSwitchInterpreter
					if(subContext628 != null)
					{
						
						
						{
							UnityEngine.GameObject subContext629 = subContext628.Where; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.GameObject subContext629 ContextPropertySwitchInterpreter
							if(subContext629 != null)
							{
								
								{
									Interactables subContext630 = (Interactables)subContext629.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
									//ContextStatement Interactables subContext630 ContextSwitchInterpreter
									if(subContext630 != null)
									{
										
										UnityEngine.GameObject OperandVar631 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										OperandVar631 = root;
										subContext630.Detach((UnityEngine.GameObject)( (OperandVar631)));
									}
								}
							}
						}
					}
				}
				
				{
					//ContextStatement UnityEngine.GameObject another_city ContextSwitchInterpreter
					if(another_city != null)
					{
						
						
						{
							Interactables subContext632 = (Interactables)another_city.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
							//ContextStatement Interactables subContext632 ContextSwitchInterpreter
							if(subContext632 != null)
							{
								
								UnityEngine.GameObject OperandVar633 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar633 = root;
								subContext632.Attach((UnityEngine.GameObject)( (OperandVar633)));
							}
						}
					}
				}
				
				{
					Blackboards.noble subContext634 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.noble subContext634 ContextSwitchInterpreter
					if(subContext634 != null)
					{
						
						UnityEngine.GameObject OperandVar635 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar635 = another_city;
						subContext634.Where = (UnityEngine.GameObject)( (OperandVar635));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip=("burn this heretic"), OnceInCategory=false)]
    public class burn : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar637 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable636 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable636 != null)
			{
				applicable = true;
				OperandVar637 = applicable;
			}
			return (System.Boolean) (OperandVar637);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Int32 OperandVar639 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop638 = External.Influence; //IsContext = False IsNew = False
			OperandVar639 = prop638;
			
			
			System.Single OperandVar642 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable640 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable640 != null)
			{
				System.Single prop641 = StoredVariable640.Influence; //IsContext = False IsNew = False
				OperandVar642 = prop641;
			}
			return (System.Single)( (( (OperandVar639)) * ( (0.01f)))) - ( ( (OperandVar642)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Boolean is_cultist =  (false); //IsContext = False IsNew = False
			
			{
				Blackboards.cultist subContext643 = (Blackboards.cultist)root.GetComponent(typeof(Blackboards.cultist)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.cultist subContext643 ContextSwitchInterpreter
				if(subContext643 != null)
				{
					
					
					is_cultist =  (true);
					
					System.Int32 OperandVar645 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop644 = External.Influence; //IsContext = False IsNew = False
					OperandVar645 = prop644;
					
					System.Single OperandVar648 = default(System.Single); //IsContext = False IsNew = False
					Blackboards.noble StoredVariable646 = ((Blackboards.noble)subContext643.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
					if(StoredVariable646 != null)
					{
						System.Single prop647 = StoredVariable646.Influence; //IsContext = False IsNew = False
						OperandVar648 = prop647;
					}
					
					External.Influence = (System.Int32)(( ( (OperandVar645))) + ( (( (OperandVar648)) * ( (10f)))));
					
					External.Notify(( ("it was a cultist!")).ToString());
				}
			}
			System.Boolean OperandVar649 = default(System.Boolean); //IsContext = False IsNew = False
			OperandVar649 = is_cultist;
			if(!(OperandVar649))
			{
				
				System.Int32 OperandVar651 = default(System.Int32); //IsContext = False IsNew = False
				System.Int32 prop650 = External.Influence; //IsContext = False IsNew = False
				OperandVar651 = prop650;
				
				System.Single OperandVar654 = default(System.Single); //IsContext = False IsNew = False
				Blackboards.noble StoredVariable652 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable652 != null)
				{
					System.Single prop653 = StoredVariable652.Influence; //IsContext = False IsNew = False
					OperandVar654 = prop653;
				}
				
				External.Influence = (System.Int32)(( ( (OperandVar651))) - ( (( (OperandVar654)) * ( (20f)))));
			}
			Blackboards.noble OperandVar656 = default(Blackboards.noble); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable655 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable655 != null)
			{
				OperandVar656 = StoredVariable655;
			}
			External.Destroy((UnityEngine.Object)( (OperandVar656)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip=("bribes are the best way to get loyalty!"), OnceInCategory=false)]
    public class bribe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar658 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable657 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable657 != null)
			{
				applicable = true;
				OperandVar658 = applicable;
			}
			return (System.Boolean) (OperandVar658);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			System.Int32 OperandVar660 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop659 = External.Influence; //IsContext = False IsNew = False
			OperandVar660 = prop659;
			
			System.Single OperandVar663 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable661 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable661 != null)
			{
				System.Single prop662 = StoredVariable661.Influence; //IsContext = False IsNew = False
				OperandVar663 = prop662;
			}
			
			
			System.Int32 OperandVar665 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop664 = External.Gold; //IsContext = False IsNew = False
			OperandVar665 = prop664;
			
			System.Single OperandVar667 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable661 != null)
			{
				System.Single prop666 = StoredVariable661.Influence; //IsContext = False IsNew = False
				OperandVar667 = prop666;
			}
			
			if(( (( ( (OperandVar660))) > ( ( (OperandVar663))))) && ( (( ( (OperandVar665))) > ( (( (OperandVar667)) * ( (10f)))))))
			{
				
				ut =  (1f);
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.Boolean OperandVar671 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.cultist OperandVar669 = default(Blackboards.cultist); //IsContext = False IsNew = False
			Blackboards.cultist StoredVariable668 = ((Blackboards.cultist)root.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
			if(StoredVariable668 != null)
			{
				OperandVar669 = StoredVariable668;
			}
			System.Boolean prop670 = External.Has( (OperandVar669)); //IsContext = False IsNew = False
			OperandVar671 = prop670;
			if(!(OperandVar671))
			{
				
				{
					Blackboards.noble subContext672 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.noble subContext672 ContextSwitchInterpreter
					if(subContext672 != null)
					{
						
						
						System.Single OperandVar674 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop673 = subContext672.Loyalty; //IsContext = False IsNew = False
						OperandVar674 = prop673;
						
						
						subContext672.Loyalty = (System.Single)(( ( (OperandVar674))) + ( ( (0.15f))));
					}
				}
			}
			
			System.Int32 OperandVar676 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop675 = External.Gold; //IsContext = False IsNew = False
			OperandVar676 = prop675;
			
			System.Single OperandVar679 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable677 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable677 != null)
			{
				System.Single prop678 = StoredVariable677.Influence; //IsContext = False IsNew = False
				OperandVar679 = prop678;
			}
			
			External.Gold = (System.Int32)(( ( (OperandVar676))) - ( (( (OperandVar679)) * ( (10f)))));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip=("the best of the best!"), OnceInCategory=false)]
    public class hire_agent : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar682 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.city StoredVariable680 = ((Blackboards.city)root.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
			if(StoredVariable680 != null)
			{
				Place StoredVariable681 = ((Place)StoredVariable680.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable681 != null)
				{
					applicable = true;
					OperandVar682 = applicable;
				}
			}
			return (System.Boolean) (OperandVar682);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Int32 OperandVar684 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop683 = External.Gold; //IsContext = False IsNew = False
			OperandVar684 = prop683;
			
			
			if(( ( (OperandVar684))) > ( ( (100f))))
			{
				
				ut =  (1f);
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Int32 OperandVar686 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop685 = External.Gold; //IsContext = False IsNew = False
			OperandVar686 = prop685;
			
			
			External.Gold = (System.Int32)(( ( (OperandVar686))) - ( ( (100f))));
			UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ag687 = ag; //IsContext = True IsNew = False
				Entity AddContext688 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Agent AddContext689 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
				Blackboards.human AddContext690 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.human AddContext690 ContextSwitchInterpreter
					if(AddContext690 != null)
					{
						
						System.Single OperandVar692 = default(System.Single); //IsContext = False IsNew = False
						
						
						System.Single prop691 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
						OperandVar692 = prop691;
						AddContext690.Age = (System.Int32)( (OperandVar692));
					}
				}
				Blackboards.focused_ritual AddContext693 = (Blackboards.focused_ritual)ag.AddComponent(typeof(Blackboards.focused_ritual)); //IsContext = True IsNew = True
				Named AddContext694 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext694 ContextSwitchInterpreter
					if(AddContext694 != null)
					{
						
						
						
						
						AddContext694.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
						
						
						System.String OperandVar697 = default(System.String); //IsContext = False IsNew = False
						System.String OperandVar695 = default(System.String); //IsContext = False IsNew = False
						OperandVar695 = "human_name";
						System.String prop696 = External.RandomName( (OperandVar695)); //IsContext = False IsNew = False
						if(prop696 != null)
						{
							OperandVar697 = prop696;
						}
						AddContext694.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar697)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
			
			{
				Place subContext698 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext698 ContextSwitchInterpreter
				if(subContext698 != null)
				{
					
					Agent OperandVar700 = default(Agent); //IsContext = False IsNew = False
					Agent StoredVariable699 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
					if(StoredVariable699 != null)
					{
						OperandVar700 = StoredVariable699;
					}
					subContext698.Attach((Agent)( (OperandVar700)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class agent_clear_ritual : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar710 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable701 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable701 != null)
			{
				Blackboards.focused_ritual StoredVariable702 = ((Blackboards.focused_ritual)StoredVariable701.GetComponent(typeof(Blackboards.focused_ritual))); //IsContext = False IsNew = False
				if(StoredVariable702 != null)
				{
					System.Boolean ifResult703; //IsContext = False IsNew = False
					
					System.Boolean OperandVar707 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar705 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop704 = StoredVariable702.Focus; //IsContext = False IsNew = False
					if(prop704 != null)
					{
						OperandVar705 = prop704;
					}
					System.Boolean prop706 = External.Has( (OperandVar705)); //IsContext = False IsNew = False
					OperandVar707 = prop706;
					
					System.Boolean OperandVar709 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable701 != null)
					{
						System.Boolean prop708 = StoredVariable701.IsActive; //IsContext = False IsNew = False
						OperandVar709 = prop708;
					}
					if(ifResult703 = ( ( (OperandVar707))) && ( (!(OperandVar709))))
					{
						applicable = true;
						OperandVar710 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar710);
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
				Blackboards.focused_ritual subContext711 = (Blackboards.focused_ritual)root.GetComponent(typeof(Blackboards.focused_ritual)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.focused_ritual subContext711 ContextSwitchInterpreter
				if(subContext711 != null)
				{
					
					UnityEngine.GameObject OperandVar713 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop712 = External.Nothing(); //IsContext = False IsNew = False
					if(prop712 != null)
					{
						OperandVar713 = prop712;
					}
					subContext711.Focus = (UnityEngine.GameObject)( (OperandVar713));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class aged_person : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar720 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable714 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable714 != null)
			{
				System.Boolean ifResult715; //IsContext = False IsNew = False
				System.Boolean OperandVar719 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged OperandVar717 = default(Blackboards.aged); //IsContext = False IsNew = False
				Blackboards.aged StoredVariable716 = ((Blackboards.aged)StoredVariable714.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
				if(StoredVariable716 != null)
				{
					OperandVar717 = StoredVariable716;
				}
				System.Boolean prop718 = External.Has( (OperandVar717)); //IsContext = False IsNew = False
				OperandVar719 = prop718;
				if(ifResult715 = !(OperandVar719))
				{
					applicable = true;
					OperandVar720 = applicable;
				}
			}
			return (System.Boolean) (OperandVar720);
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
			
			Blackboards.aged ContextVar721 = root.AddComponent<Blackboards.aged>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.aged ContextVar721 ContextSwitchInterpreter
				if(ContextVar721 != null)
				{
					
					System.Single OperandVar723 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop722 = External.Random( (20f), (50f)); //IsContext = False IsNew = False
					OperandVar723 = prop722;
					ContextVar721.Age = (System.Int32)( (OperandVar723));
				}
			}
			Entity EntVar724 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar724 != null) EntVar724.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class beaten_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar731 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable725 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable725 != null)
			{
				Blackboards.personality StoredVariable726 = ((Blackboards.personality)StoredVariable725.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable726 != null)
				{
					Blackboards.aged StoredVariable727 = ((Blackboards.aged)StoredVariable726.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable727 != null)
					{
						System.Boolean ifResult728; //IsContext = False IsNew = False
						
						System.Int32 OperandVar730 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop729 = StoredVariable727.CurAge; //IsContext = False IsNew = False
						OperandVar730 = prop729;
						
						
						if(ifResult728 = ( ( (OperandVar730))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar731 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar731);
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
				Blackboards.aged subContext732 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext732 ContextSwitchInterpreter
				if(subContext732 != null)
				{
					
					
					System.Int32 OperandVar734 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop733 = subContext732.CurAge; //IsContext = False IsNew = False
					OperandVar734 = prop733;
					
					
					subContext732.CurAge = (System.Int32)(( ( (OperandVar734))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext735 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext735 ContextSwitchInterpreter
				if(subContext735 != null)
				{
					
					
					System.Single OperandVar737 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop736 = subContext735.Cruel; //IsContext = False IsNew = False
					OperandVar737 = prop736;
					
					
					subContext735.Cruel = (System.Single)(( ( (OperandVar737))) + ( ( (0.1f))));
					
					System.Single OperandVar739 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop738 = subContext735.Reckless; //IsContext = False IsNew = False
					OperandVar739 = prop738;
					
					
					subContext735.Reckless = (System.Single)(( ( (OperandVar739))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cherished_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar746 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable740 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable740 != null)
			{
				Blackboards.personality StoredVariable741 = ((Blackboards.personality)StoredVariable740.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable741 != null)
				{
					Blackboards.aged StoredVariable742 = ((Blackboards.aged)StoredVariable741.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable742 != null)
					{
						System.Boolean ifResult743; //IsContext = False IsNew = False
						
						System.Int32 OperandVar745 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop744 = StoredVariable742.CurAge; //IsContext = False IsNew = False
						OperandVar745 = prop744;
						
						
						if(ifResult743 = ( ( (OperandVar745))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar746 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar746);
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
				Blackboards.aged subContext747 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext747 ContextSwitchInterpreter
				if(subContext747 != null)
				{
					
					
					System.Int32 OperandVar749 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop748 = subContext747.CurAge; //IsContext = False IsNew = False
					OperandVar749 = prop748;
					
					
					subContext747.CurAge = (System.Int32)(( ( (OperandVar749))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext750 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext750 ContextSwitchInterpreter
				if(subContext750 != null)
				{
					
					
					System.Single OperandVar752 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop751 = subContext750.Brave; //IsContext = False IsNew = False
					OperandVar752 = prop751;
					
					
					subContext750.Brave = (System.Single)(( ( (OperandVar752))) - ( ( (0.1f))));
					
					System.Single OperandVar754 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop753 = subContext750.Optimistic; //IsContext = False IsNew = False
					OperandVar754 = prop753;
					
					
					subContext750.Optimistic = (System.Single)(( ( (OperandVar754))) + ( ( (0.2f))));
					
					System.Single OperandVar756 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop755 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar756 = prop755;
					
					
					if(( ( (OperandVar756))) > ( ( (0.9f))))
					{
						
						System.Single OperandVar758 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop757 = subContext750.Cruel; //IsContext = False IsNew = False
						OperandVar758 = prop757;
						
						
						subContext750.Cruel = (System.Single)(( ( (OperandVar758))) + ( ( (0.1f))));
					}
					
					System.Single OperandVar760 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop759 = subContext750.Ambitious; //IsContext = False IsNew = False
					OperandVar760 = prop759;
					
					
					subContext750.Ambitious = (System.Single)(( ( (OperandVar760))) - ( ( (0.03f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class inspired_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar767 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable761 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable761 != null)
			{
				Blackboards.personality StoredVariable762 = ((Blackboards.personality)StoredVariable761.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable762 != null)
				{
					Blackboards.aged StoredVariable763 = ((Blackboards.aged)StoredVariable762.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable763 != null)
					{
						System.Boolean ifResult764; //IsContext = False IsNew = False
						
						System.Int32 OperandVar766 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop765 = StoredVariable763.CurAge; //IsContext = False IsNew = False
						OperandVar766 = prop765;
						
						
						if(ifResult764 = ( ( (OperandVar766))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar767 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar767);
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
				Blackboards.aged subContext768 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext768 ContextSwitchInterpreter
				if(subContext768 != null)
				{
					
					
					System.Int32 OperandVar770 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop769 = subContext768.CurAge; //IsContext = False IsNew = False
					OperandVar770 = prop769;
					
					
					subContext768.CurAge = (System.Int32)(( ( (OperandVar770))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext771 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext771 ContextSwitchInterpreter
				if(subContext771 != null)
				{
					
					
					System.Single OperandVar773 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop772 = subContext771.Brave; //IsContext = False IsNew = False
					OperandVar773 = prop772;
					
					
					subContext771.Brave = (System.Single)(( ( (OperandVar773))) + ( ( (0.2f))));
					
					System.Single OperandVar775 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop774 = subContext771.Optimistic; //IsContext = False IsNew = False
					OperandVar775 = prop774;
					
					
					subContext771.Optimistic = (System.Single)(( ( (OperandVar775))) + ( ( (0.5f))));
					
					System.Single OperandVar777 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop776 = subContext771.Ambitious; //IsContext = False IsNew = False
					OperandVar777 = prop776;
					
					
					subContext771.Ambitious = (System.Single)(( ( (OperandVar777))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class taught_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar784 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable778 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable778 != null)
			{
				Blackboards.personality StoredVariable779 = ((Blackboards.personality)StoredVariable778.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable779 != null)
				{
					Blackboards.aged StoredVariable780 = ((Blackboards.aged)StoredVariable779.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable780 != null)
					{
						System.Boolean ifResult781; //IsContext = False IsNew = False
						
						System.Int32 OperandVar783 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop782 = StoredVariable780.CurAge; //IsContext = False IsNew = False
						OperandVar783 = prop782;
						
						
						if(ifResult781 = ( ( (OperandVar783))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar784 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar784);
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
				Blackboards.aged subContext785 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext785 ContextSwitchInterpreter
				if(subContext785 != null)
				{
					
					
					System.Int32 OperandVar787 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop786 = subContext785.CurAge; //IsContext = False IsNew = False
					OperandVar787 = prop786;
					
					
					subContext785.CurAge = (System.Int32)(( ( (OperandVar787))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext788 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext788 ContextSwitchInterpreter
				if(subContext788 != null)
				{
					
					
					System.Single OperandVar790 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop789 = subContext788.Rational; //IsContext = False IsNew = False
					OperandVar790 = prop789;
					
					
					subContext788.Rational = (System.Single)(( ( (OperandVar790))) + ( ( (0.1f))));
					
					System.Single OperandVar792 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop791 = subContext788.Ambitious; //IsContext = False IsNew = False
					OperandVar792 = prop791;
					
					
					subContext788.Ambitious = (System.Single)(( ( (OperandVar792))) + ( ( (0.05f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class pushy_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar799 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable793 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable793 != null)
			{
				Blackboards.personality StoredVariable794 = ((Blackboards.personality)StoredVariable793.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable794 != null)
				{
					Blackboards.aged StoredVariable795 = ((Blackboards.aged)StoredVariable794.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable795 != null)
					{
						System.Boolean ifResult796; //IsContext = False IsNew = False
						
						System.Int32 OperandVar798 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop797 = StoredVariable795.CurAge; //IsContext = False IsNew = False
						OperandVar798 = prop797;
						
						
						if(ifResult796 = ( ( (OperandVar798))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar799 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar799);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar802 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable800 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable800 != null)
			{
				System.Single prop801 = StoredVariable800.Brave; //IsContext = False IsNew = False
				OperandVar802 = prop801;
			}
			
			System.Single OperandVar804 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable800 != null)
			{
				System.Single prop803 = StoredVariable800.Ambitious; //IsContext = False IsNew = False
				OperandVar804 = prop803;
			}
			
			System.Single OperandVar806 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable800 != null)
			{
				System.Single prop805 = StoredVariable800.Cruel; //IsContext = False IsNew = False
				OperandVar806 = prop805;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar802))) + ( ( (OperandVar804))) - ( ( (OperandVar806)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext807 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext807 ContextSwitchInterpreter
				if(subContext807 != null)
				{
					
					
					System.Int32 OperandVar809 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop808 = subContext807.CurAge; //IsContext = False IsNew = False
					OperandVar809 = prop808;
					
					System.Single OperandVar811 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop810 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar811 = prop810;
					subContext807.CurAge = (System.Int32)(( ( (OperandVar809))) + ( ( (OperandVar811))));
				}
			}
			
			{
				Blackboards.personality subContext812 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext812 ContextSwitchInterpreter
				if(subContext812 != null)
				{
					
					
					System.Single OperandVar814 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop813 = subContext812.Brave; //IsContext = False IsNew = False
					OperandVar814 = prop813;
					
					
					subContext812.Brave = (System.Single)(( ( (OperandVar814))) + ( ( (0.3f))));
					
					System.Single OperandVar816 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop815 = subContext812.Rational; //IsContext = False IsNew = False
					OperandVar816 = prop815;
					
					
					subContext812.Rational = (System.Single)(( ( (OperandVar816))) - ( ( (0.1f))));
					
					System.Single OperandVar818 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop817 = subContext812.Optimistic; //IsContext = False IsNew = False
					OperandVar818 = prop817;
					
					
					subContext812.Optimistic = (System.Single)(( ( (OperandVar818))) + ( ( (0.3f))));
					
					System.Single OperandVar820 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop819 = subContext812.Ambitious; //IsContext = False IsNew = False
					OperandVar820 = prop819;
					
					
					subContext812.Ambitious = (System.Single)(( ( (OperandVar820))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class nerd_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar827 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable821 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable821 != null)
			{
				Blackboards.personality StoredVariable822 = ((Blackboards.personality)StoredVariable821.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable822 != null)
				{
					Blackboards.aged StoredVariable823 = ((Blackboards.aged)StoredVariable822.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable823 != null)
					{
						System.Boolean ifResult824; //IsContext = False IsNew = False
						
						System.Int32 OperandVar826 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop825 = StoredVariable823.CurAge; //IsContext = False IsNew = False
						OperandVar826 = prop825;
						
						
						if(ifResult824 = ( ( (OperandVar826))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar827 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar827);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar830 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable828 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable828 != null)
			{
				System.Single prop829 = StoredVariable828.Rational; //IsContext = False IsNew = False
				OperandVar830 = prop829;
			}
			
			System.Single OperandVar832 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable828 != null)
			{
				System.Single prop831 = StoredVariable828.Brave; //IsContext = False IsNew = False
				OperandVar832 = prop831;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar830))) - ( ( (OperandVar832)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext833 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext833 ContextSwitchInterpreter
				if(subContext833 != null)
				{
					
					
					System.Int32 OperandVar835 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop834 = subContext833.CurAge; //IsContext = False IsNew = False
					OperandVar835 = prop834;
					
					System.Single OperandVar837 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop836 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar837 = prop836;
					subContext833.CurAge = (System.Int32)(( ( (OperandVar835))) + ( ( (OperandVar837))));
				}
			}
			
			{
				Blackboards.personality subContext838 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext838 ContextSwitchInterpreter
				if(subContext838 != null)
				{
					
					
					System.Single OperandVar840 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop839 = subContext838.Brave; //IsContext = False IsNew = False
					OperandVar840 = prop839;
					
					
					subContext838.Brave = (System.Single)(( ( (OperandVar840))) - ( ( (0.1f))));
					
					System.Single OperandVar842 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop841 = subContext838.Rational; //IsContext = False IsNew = False
					OperandVar842 = prop841;
					
					
					subContext838.Rational = (System.Single)(( ( (OperandVar842))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class manipulative_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar849 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable843 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable843 != null)
			{
				Blackboards.personality StoredVariable844 = ((Blackboards.personality)StoredVariable843.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable844 != null)
				{
					Blackboards.aged StoredVariable845 = ((Blackboards.aged)StoredVariable844.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable845 != null)
					{
						System.Boolean ifResult846; //IsContext = False IsNew = False
						
						System.Int32 OperandVar848 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop847 = StoredVariable845.CurAge; //IsContext = False IsNew = False
						OperandVar848 = prop847;
						
						
						if(ifResult846 = ( ( (OperandVar848))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar849 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar849);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar852 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable850 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable850 != null)
			{
				System.Single prop851 = StoredVariable850.Rational; //IsContext = False IsNew = False
				OperandVar852 = prop851;
			}
			
			System.Single OperandVar854 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable850 != null)
			{
				System.Single prop853 = StoredVariable850.Ambitious; //IsContext = False IsNew = False
				OperandVar854 = prop853;
			}
			
			return (System.Single)( ( (0.2f))) + ( ( (OperandVar852))) + ( (( (OperandVar854)) * ( (2f))));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext855 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext855 ContextSwitchInterpreter
				if(subContext855 != null)
				{
					
					
					System.Int32 OperandVar857 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop856 = subContext855.CurAge; //IsContext = False IsNew = False
					OperandVar857 = prop856;
					
					System.Single OperandVar859 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop858 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar859 = prop858;
					subContext855.CurAge = (System.Int32)(( ( (OperandVar857))) + ( ( (OperandVar859))));
				}
			}
			
			{
				Blackboards.personality subContext860 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext860 ContextSwitchInterpreter
				if(subContext860 != null)
				{
					
					
					System.Single OperandVar862 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop861 = subContext860.Brave; //IsContext = False IsNew = False
					OperandVar862 = prop861;
					
					
					subContext860.Brave = (System.Single)(( ( (OperandVar862))) - ( ( (0.2f))));
					
					System.Single OperandVar864 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop863 = subContext860.Ambitious; //IsContext = False IsNew = False
					OperandVar864 = prop863;
					
					
					subContext860.Ambitious = (System.Single)(( ( (OperandVar864))) + ( ( (0.3f))));
					
					System.Single OperandVar866 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop865 = subContext860.Reckless; //IsContext = False IsNew = False
					OperandVar866 = prop865;
					
					
					subContext860.Reckless = (System.Single)(( ( (OperandVar866))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class tortured_pets_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar873 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable867 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable867 != null)
			{
				Blackboards.personality StoredVariable868 = ((Blackboards.personality)StoredVariable867.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable868 != null)
				{
					Blackboards.aged StoredVariable869 = ((Blackboards.aged)StoredVariable868.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable869 != null)
					{
						System.Boolean ifResult870; //IsContext = False IsNew = False
						
						System.Int32 OperandVar872 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop871 = StoredVariable869.CurAge; //IsContext = False IsNew = False
						OperandVar872 = prop871;
						
						
						if(ifResult870 = ( ( (OperandVar872))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar873 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar873);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar876 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable874 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable874 != null)
			{
				System.Single prop875 = StoredVariable874.Cruel; //IsContext = False IsNew = False
				OperandVar876 = prop875;
			}
			
			return (System.Single)( (OperandVar876)) * ( (0.8f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext877 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext877 ContextSwitchInterpreter
				if(subContext877 != null)
				{
					
					
					System.Int32 OperandVar879 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop878 = subContext877.CurAge; //IsContext = False IsNew = False
					OperandVar879 = prop878;
					
					System.Single OperandVar881 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop880 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar881 = prop880;
					subContext877.CurAge = (System.Int32)(( ( (OperandVar879))) + ( ( (OperandVar881))));
				}
			}
			
			{
				Blackboards.personality subContext882 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext882 ContextSwitchInterpreter
				if(subContext882 != null)
				{
					
					
					System.Single OperandVar884 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop883 = subContext882.Rational; //IsContext = False IsNew = False
					OperandVar884 = prop883;
					
					
					subContext882.Rational = (System.Single)(( ( (OperandVar884))) - ( ( (0.1f))));
					
					System.Single OperandVar886 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop885 = subContext882.Cruel; //IsContext = False IsNew = False
					OperandVar886 = prop885;
					
					
					subContext882.Cruel = (System.Single)(( ( (OperandVar886))) + ( ( (0.5f))));
					
					System.Single OperandVar888 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop887 = subContext882.Reckless; //IsContext = False IsNew = False
					OperandVar888 = prop887;
					
					
					subContext882.Reckless = (System.Single)(( ( (OperandVar888))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar902 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable889 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable889 != null)
			{
				Markers StoredVariable890 = ((Markers)StoredVariable889.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable890 != null)
				{
					System.Boolean ifResult891; //IsContext = False IsNew = False
					
					System.Boolean OperandVar898 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable889 != null)
					{
						UnityEngine.GameObject prop892 = StoredVariable889.ShowedObject; //IsContext = False IsNew = False
						if(prop892 != null)
						{
							System.Boolean ifResult893; //IsContext = False IsNew = False
							System.Boolean OperandVar897 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar895 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable894 = ((Named)prop892.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable894 != null)
							{
								OperandVar895 = StoredVariable894;
							}
							System.Boolean prop896 = External.Has( (OperandVar895)); //IsContext = False IsNew = False
							OperandVar897 = prop896;
							if(ifResult893 =  (OperandVar897))
							{
								OperandVar898 = ifResult893;
							}
						}
					}
					
					System.Boolean OperandVar901 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar899 = default(System.String); //IsContext = False IsNew = False
					OperandVar899 = "named_ui_marker";
					System.Boolean prop900 = StoredVariable890.HasMarker( (OperandVar899)); //IsContext = False IsNew = False
					OperandVar901 = prop900;
					if(ifResult891 = ( ( (OperandVar898))) && ( (!(OperandVar901))))
					{
						applicable = true;
						OperandVar902 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar902);
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
			
			UnityEngine.GameObject OperandVar903 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar903 = root;
			UnityEngine.GameObject ctx =  (OperandVar903); //IsContext = False IsNew = False
			
			{
				BarsManager subContext904 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext904 ContextSwitchInterpreter
				if(subContext904 != null)
				{
					
					UnityEngine.GameObject OperandVar906 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop905 = subContext904.GetLeftBar(); //IsContext = False IsNew = False
					if(prop905 != null)
					{
						OperandVar906 = prop905;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar906); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							
							System.Boolean OperandVar910 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar908 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable907 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable907 != null)
							{
								OperandVar908 = StoredVariable907;
							}
							System.Boolean prop909 = External.Has( (OperandVar908)); //IsContext = False IsNew = False
							OperandVar910 = prop909;
							if( (OperandVar910))
							{
								UnityEngine.GameObject OperandVar911 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar911 = p_ctx;
								ctx =  (OperandVar911);
							}
						}
					}
				}
			}
			
			{
				Markers subContext912 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext912 ContextSwitchInterpreter
				if(subContext912 != null)
				{
					
					System.String OperandVar913 = default(System.String); //IsContext = False IsNew = False
					OperandVar913 = "named_ui_marker";
					subContext912.SetUiMarker(( (OperandVar913)).ToString());
				}
			}
			
			{
				//ContextStatement UnityEngine.GameObject ctx ContextSwitchInterpreter
				if(ctx != null)
				{
					
					
					{
						UiObject subContext914 = (UiObject)ctx.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
						//ContextStatement UiObject subContext914 ContextSwitchInterpreter
						if(subContext914 != null)
						{
							
							Named OperandVar917 = default(Named); //IsContext = False IsNew = False
							UnityEngine.GameObject prop915 = subContext914.ShowedObject; //IsContext = False IsNew = False
							if(prop915 != null)
							{
								Named StoredVariable916 = ((Named)prop915.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable916 != null)
								{
									OperandVar917 = StoredVariable916;
								}
							}
							Named showed_named =  (OperandVar917); //IsContext = False IsNew = False
							TextField ContextVar918 = ctx.AddComponent<TextField>();; //IsContext = False IsNew = True
							
							{
								//ContextStatement TextField ContextVar918 ContextSwitchInterpreter
								if(ContextVar918 != null)
								{
									
									System.String OperandVar920 = default(System.String); //IsContext = False IsNew = False
									System.String prop919 = showed_named.FullName; //IsContext = False IsNew = False
									if(prop919 != null)
									{
										OperandVar920 = prop919;
									}
									ContextVar918.Show(( (OperandVar920)).ToString());
									
									{
										//ContextStatement Named showed_named ContextSwitchInterpreter
										if(showed_named != null)
										{
											
											VoidDelegate Lambda921 = () => 
											{
												System.String OperandVar923 = default(System.String); //IsContext = False IsNew = False
												System.String prop922 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop922 != null)
												{
													OperandVar923 = prop922;
												}
												ContextVar918.Show(( (OperandVar923)).ToString());
											};
											showed_named.OnUpdate(Lambda921);
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext924 = ContextVar918.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext924 ContextPropertySwitchInterpreter
										if(subContext924 != null)
										{
											
											subContext924.minHeight = (System.Single)( (20f));
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext925 = ContextVar918.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext925 ContextPropertySwitchInterpreter
										if(subContext925 != null)
										{
											
											subContext925.minWidth = (System.Single)( (100f));
										}
									}
								}
							}
							Entity EntVar926 = (Entity)ctx.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
							if(EntVar926 != null) EntVar926.ComponentAdded();
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar933 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable927 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable927 != null)
			{
				System.Boolean ifResult928; //IsContext = False IsNew = False
				System.Boolean OperandVar932 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar930 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable929 = ((Blackboards.event_marker)StoredVariable927.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable929 != null)
				{
					OperandVar930 = StoredVariable929;
				}
				System.Boolean prop931 = External.Has( (OperandVar930)); //IsContext = False IsNew = False
				OperandVar932 = prop931;
				if(ifResult928 = !(OperandVar932))
				{
					applicable = true;
					OperandVar933 = applicable;
				}
			}
			return (System.Boolean) (OperandVar933);
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
			Entity EntVar934 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar934 != null) EntVar934.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar936 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable935 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable935 != null)
			{
				applicable = true;
				OperandVar936 = applicable;
			}
			return (System.Boolean) (OperandVar936);
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
			
			UnityEngine.GameObject OperandVar937 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar937 = root;
			External.MapEnlistDetailed((UnityEngine.GameObject)( (OperandVar937)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar944 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable938 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable938 != null)
			{
				Markers StoredVariable939 = ((Markers)StoredVariable938.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable939 != null)
				{
					System.Boolean ifResult940; //IsContext = False IsNew = False
					System.Boolean OperandVar943 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar941 = default(System.String); //IsContext = False IsNew = False
					OperandVar941 = "encounter_ui_enlist";
					System.Boolean prop942 = StoredVariable939.HasMarker( (OperandVar941)); //IsContext = False IsNew = False
					OperandVar943 = prop942;
					if(ifResult940 = !(OperandVar943))
					{
						applicable = true;
						OperandVar944 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar944);
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
				Markers subContext945 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext945 ContextSwitchInterpreter
				if(subContext945 != null)
				{
					
					System.String OperandVar946 = default(System.String); //IsContext = False IsNew = False
					OperandVar946 = "encounter_ui_enlist";
					subContext945.SetUiMarker(( (OperandVar946)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar947 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar947 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar947)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar961 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable948 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable948 != null)
			{
				Markers StoredVariable949 = ((Markers)StoredVariable948.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable949 != null)
				{
					System.Boolean ifResult950; //IsContext = False IsNew = False
					
					System.Boolean OperandVar957 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable948 != null)
					{
						UnityEngine.GameObject prop951 = StoredVariable948.ShowedObject; //IsContext = False IsNew = False
						if(prop951 != null)
						{
							System.Boolean ifResult952; //IsContext = False IsNew = False
							System.Boolean OperandVar956 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar954 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable953 = ((Place)prop951.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable953 != null)
							{
								OperandVar954 = StoredVariable953;
							}
							System.Boolean prop955 = External.Has( (OperandVar954)); //IsContext = False IsNew = False
							OperandVar956 = prop955;
							if(ifResult952 =  (OperandVar956))
							{
								OperandVar957 = ifResult952;
							}
						}
					}
					
					System.Boolean OperandVar960 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar958 = default(System.String); //IsContext = False IsNew = False
					OperandVar958 = "place_ui_cards_list";
					System.Boolean prop959 = StoredVariable949.HasMarker( (OperandVar958)); //IsContext = False IsNew = False
					OperandVar960 = prop959;
					if(ifResult950 = ( ( (OperandVar957))) && ( (!(OperandVar960))))
					{
						applicable = true;
						OperandVar961 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar961);
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
			
			UnityEngine.GameObject OperandVar962 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar962 = root;
			UnityEngine.GameObject ctx =  (OperandVar962); //IsContext = False IsNew = False
			
			{
				BarsManager subContext963 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext963 ContextSwitchInterpreter
				if(subContext963 != null)
				{
					
					UnityEngine.GameObject OperandVar965 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop964 = subContext963.GetBottomBar(); //IsContext = False IsNew = False
					if(prop964 != null)
					{
						OperandVar965 = prop964;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar965); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							
							System.Boolean OperandVar969 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar967 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable966 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable966 != null)
							{
								OperandVar967 = StoredVariable966;
							}
							System.Boolean prop968 = External.Has( (OperandVar967)); //IsContext = False IsNew = False
							OperandVar969 = prop968;
							if( (OperandVar969))
							{
								UnityEngine.GameObject OperandVar970 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar970 = p_ctx;
								ctx =  (OperandVar970);
							}
						}
					}
				}
			}
			
			{
				Markers subContext971 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext971 ContextSwitchInterpreter
				if(subContext971 != null)
				{
					
					System.String OperandVar972 = default(System.String); //IsContext = False IsNew = False
					OperandVar972 = "place_ui_cards_list";
					subContext971.SetUiMarker(( (OperandVar972)).ToString());
				}
			}
			Place OperandVar976 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable973 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable973 != null)
			{
				UnityEngine.GameObject prop974 = StoredVariable973.ShowedObject; //IsContext = False IsNew = False
				if(prop974 != null)
				{
					Place StoredVariable975 = ((Place)prop974.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable975 != null)
					{
						OperandVar976 = StoredVariable975;
					}
				}
			}
			Place pl =  (OperandVar976); //IsContext = False IsNew = False
			System.String OperandVar977 = default(System.String); //IsContext = False IsNew = False
			OperandVar977 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx978 = External.SpawnPrefab(( (OperandVar977)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx978 ContextPropertySwitchInterpreter
				if(FuncCtx978 != null)
				{
					
					{
						AgentsUI subContext979 = (AgentsUI)FuncCtx978.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext979 ContextSwitchInterpreter
						if(subContext979 != null)
						{
							
							Place OperandVar980 = default(Place); //IsContext = False IsNew = False
							OperandVar980 = pl;
							subContext979.TargetPlace = (Place)( (OperandVar980));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext981 = (CardsHolderAgentsAdapter)FuncCtx978.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext981 ContextSwitchInterpreter
						if(subContext981 != null)
						{
							
							Place OperandVar982 = default(Place); //IsContext = False IsNew = False
							OperandVar982 = pl;
							subContext981.TargetPlace = (Place)( (OperandVar982));
						}
					}
					UnityEngine.GameObject OperandVar983 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar983 = FuncCtx978;
					UnityEngine.GameObject OperandVar984 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar984 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar983)),(UnityEngine.GameObject)( (OperandVar984)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar990 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable985 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable985 != null)
			{
				System.Boolean ifResult986; //IsContext = False IsNew = False
				System.Boolean OperandVar989 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop987 = StoredVariable985.ShowedObject; //IsContext = False IsNew = False
				if(prop987 != null)
				{
					Place StoredVariable988 = ((Place)prop987.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable988 != null)
					{
						applicable = true;
						OperandVar989 = applicable;
					}
				}
				if(ifResult986 =  (OperandVar989))
				{
					applicable = true;
					OperandVar990 = applicable;
				}
			}
			return (System.Boolean) (OperandVar990);
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
			
			UnityEngine.GameObject OperandVar991 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar991 = root;
			UnityEngine.GameObject ctx =  (OperandVar991); //IsContext = False IsNew = False
			
			{
				BarsManager subContext992 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext992 ContextSwitchInterpreter
				if(subContext992 != null)
				{
					
					UnityEngine.GameObject OperandVar994 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop993 = subContext992.GetLeftBar(); //IsContext = False IsNew = False
					if(prop993 != null)
					{
						OperandVar994 = prop993;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar994); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							
							System.Boolean OperandVar998 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar996 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable995 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable995 != null)
							{
								OperandVar996 = StoredVariable995;
							}
							System.Boolean prop997 = External.Has( (OperandVar996)); //IsContext = False IsNew = False
							OperandVar998 = prop997;
							if( (OperandVar998))
							{
								UnityEngine.GameObject OperandVar999 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar999 = p_ctx;
								ctx =  (OperandVar999);
							}
						}
					}
				}
			}
			
			{
				//ContextStatement UnityEngine.GameObject ctx ContextSwitchInterpreter
				if(ctx != null)
				{
					
					TextField ContextVar1000 = ctx.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar1000 ContextSwitchInterpreter
						if(ContextVar1000 != null)
						{
							
							
							ContextVar1000.Label = (System.String)( ("size"));
							System.Int32 OperandVar1005 = default(System.Int32); //IsContext = False IsNew = False
							UiObject StoredVariable1001 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable1001 != null)
							{
								UnityEngine.GameObject prop1002 = StoredVariable1001.ShowedObject; //IsContext = False IsNew = False
								if(prop1002 != null)
								{
									Place StoredVariable1003 = ((Place)prop1002.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable1003 != null)
									{
										System.Int32 prop1004 = StoredVariable1003.Size; //IsContext = False IsNew = False
										OperandVar1005 = prop1004;
									}
								}
							}
							ContextVar1000.Show(( (OperandVar1005)).ToString());
							
							{
								UnityEngine.UI.LayoutElement subContext1006 = ContextVar1000.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext1006 ContextPropertySwitchInterpreter
								if(subContext1006 != null)
								{
									
									subContext1006.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext1007 = ContextVar1000.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext1007 ContextPropertySwitchInterpreter
								if(subContext1007 != null)
								{
									
									subContext1007.minWidth = (System.Single)( (100f));
								}
							}
						}
					}
					Entity EntVar1008 = (Entity)ctx.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar1008 != null) EntVar1008.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class interactables_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1018 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable1009 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable1009 != null)
			{
				System.Boolean ifResult1010; //IsContext = False IsNew = False
				System.Boolean OperandVar1017 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop1011 = StoredVariable1009.ShowedObject; //IsContext = False IsNew = False
				if(prop1011 != null)
				{
					System.Boolean ifResult1012; //IsContext = False IsNew = False
					System.Boolean OperandVar1016 = default(System.Boolean); //IsContext = False IsNew = False
					Interactables OperandVar1014 = default(Interactables); //IsContext = False IsNew = False
					Interactables StoredVariable1013 = ((Interactables)prop1011.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable1013 != null)
					{
						OperandVar1014 = StoredVariable1013;
					}
					System.Boolean prop1015 = External.Has( (OperandVar1014)); //IsContext = False IsNew = False
					OperandVar1016 = prop1015;
					if(ifResult1012 =  (OperandVar1016))
					{
						OperandVar1017 = ifResult1012;
					}
				}
				if(ifResult1010 =  (OperandVar1017))
				{
					applicable = true;
					OperandVar1018 = applicable;
				}
			}
			return (System.Boolean) (OperandVar1018);
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
			
			UnityEngine.GameObject OperandVar1019 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar1019 = root;
			UnityEngine.GameObject ctx =  (OperandVar1019); //IsContext = False IsNew = False
			
			{
				BarsManager subContext1020 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext1020 ContextSwitchInterpreter
				if(subContext1020 != null)
				{
					
					UnityEngine.GameObject OperandVar1022 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop1021 = subContext1020.GetTopBar(); //IsContext = False IsNew = False
					if(prop1021 != null)
					{
						OperandVar1022 = prop1021;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar1022); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							
							System.Boolean OperandVar1026 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar1024 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable1023 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable1023 != null)
							{
								OperandVar1024 = StoredVariable1023;
							}
							System.Boolean prop1025 = External.Has( (OperandVar1024)); //IsContext = False IsNew = False
							OperandVar1026 = prop1025;
							if( (OperandVar1026))
							{
								UnityEngine.GameObject OperandVar1027 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar1027 = p_ctx;
								ctx =  (OperandVar1027);
							}
						}
					}
				}
			}
			Interactables OperandVar1031 = default(Interactables); //IsContext = False IsNew = False
			UiObject StoredVariable1028 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable1028 != null)
			{
				UnityEngine.GameObject prop1029 = StoredVariable1028.ShowedObject; //IsContext = False IsNew = False
				if(prop1029 != null)
				{
					Interactables StoredVariable1030 = ((Interactables)prop1029.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable1030 != null)
					{
						OperandVar1031 = StoredVariable1030;
					}
				}
			}
			Interactables inter =  (OperandVar1031); //IsContext = False IsNew = False
			System.String OperandVar1032 = default(System.String); //IsContext = False IsNew = False
			OperandVar1032 = "interactables_ui";
			
			{
				UnityEngine.GameObject FuncCtx1033 = External.SpawnPrefab(( (OperandVar1032)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx1033 ContextPropertySwitchInterpreter
				if(FuncCtx1033 != null)
				{
					
					{
						InteractablesUI subContext1034 = (InteractablesUI)FuncCtx1033.GetComponent(typeof(InteractablesUI)); //IsContext = True IsNew = False
						//ContextStatement InteractablesUI subContext1034 ContextSwitchInterpreter
						if(subContext1034 != null)
						{
							
							Interactables OperandVar1035 = default(Interactables); //IsContext = False IsNew = False
							OperandVar1035 = inter;
							subContext1034.TargetInteractables = (Interactables)( (OperandVar1035));
						}
					}
					UnityEngine.GameObject OperandVar1036 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar1036 = FuncCtx1033;
					UnityEngine.GameObject OperandVar1037 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar1037 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar1036)),(UnityEngine.GameObject)( (OperandVar1037)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class interactable_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1051 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable1038 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable1038 != null)
			{
				System.Boolean ifResult1039; //IsContext = False IsNew = False
				
				System.Boolean OperandVar1046 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop1040 = StoredVariable1038.ShowedObject; //IsContext = False IsNew = False
				if(prop1040 != null)
				{
					System.Boolean ifResult1041; //IsContext = False IsNew = False
					System.Boolean OperandVar1045 = default(System.Boolean); //IsContext = False IsNew = False
					Interactable OperandVar1043 = default(Interactable); //IsContext = False IsNew = False
					Interactable StoredVariable1042 = ((Interactable)prop1040.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
					if(StoredVariable1042 != null)
					{
						OperandVar1043 = StoredVariable1042;
					}
					System.Boolean prop1044 = External.Has( (OperandVar1043)); //IsContext = False IsNew = False
					OperandVar1045 = prop1044;
					if(ifResult1041 =  (OperandVar1045))
					{
						OperandVar1046 = ifResult1041;
					}
				}
				
				System.Boolean OperandVar1050 = default(System.Boolean); //IsContext = False IsNew = False
				SelectableMarker OperandVar1048 = default(SelectableMarker); //IsContext = False IsNew = False
				SelectableMarker StoredVariable1047 = ((SelectableMarker)StoredVariable1038.GetComponent(typeof(SelectableMarker))); //IsContext = False IsNew = False
				if(StoredVariable1047 != null)
				{
					OperandVar1048 = StoredVariable1047;
				}
				System.Boolean prop1049 = External.Has( (OperandVar1048)); //IsContext = False IsNew = False
				OperandVar1050 = prop1049;
				if(ifResult1039 = ( ( (OperandVar1046))) && ( (!(OperandVar1050))))
				{
					applicable = true;
					OperandVar1051 = applicable;
				}
			}
			return (System.Boolean) (OperandVar1051);
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
			
			
			External.Log((System.Object)( ("interactable UI")));
			UnityEngine.GameObject OperandVar1052 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar1052 = root;
			UnityEngine.GameObject ctx =  (OperandVar1052); //IsContext = False IsNew = False
			
			{
				BarsManager subContext1053 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext1053 ContextSwitchInterpreter
				if(subContext1053 != null)
				{
					
					UnityEngine.GameObject OperandVar1055 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop1054 = subContext1053.GetRightBar(); //IsContext = False IsNew = False
					if(prop1054 != null)
					{
						OperandVar1055 = prop1054;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar1055); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							
							System.Boolean OperandVar1059 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar1057 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable1056 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable1056 != null)
							{
								OperandVar1057 = StoredVariable1056;
							}
							System.Boolean prop1058 = External.Has( (OperandVar1057)); //IsContext = False IsNew = False
							OperandVar1059 = prop1058;
							if( (OperandVar1059))
							{
								UnityEngine.GameObject OperandVar1060 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar1060 = p_ctx;
								ctx =  (OperandVar1060);
							}
						}
					}
				}
			}
			
			{
				//ContextStatement UnityEngine.GameObject ctx ContextSwitchInterpreter
				if(ctx != null)
				{
					
					System.String OperandVar1061 = default(System.String); //IsContext = False IsNew = False
					OperandVar1061 = "interactions_ui";
					
					{
						UnityEngine.GameObject FuncCtx1062 = External.SpawnPrefab(( (OperandVar1061)).ToString());; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject FuncCtx1062 ContextPropertySwitchInterpreter
						if(FuncCtx1062 != null)
						{
							
							{
								InteractableUI subContext1063 = (InteractableUI)FuncCtx1062.GetComponent(typeof(InteractableUI)); //IsContext = True IsNew = False
								//ContextStatement InteractableUI subContext1063 ContextSwitchInterpreter
								if(subContext1063 != null)
								{
									
									Interactable OperandVar1067 = default(Interactable); //IsContext = False IsNew = False
									UiObject StoredVariable1064 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
									if(StoredVariable1064 != null)
									{
										UnityEngine.GameObject prop1065 = StoredVariable1064.ShowedObject; //IsContext = False IsNew = False
										if(prop1065 != null)
										{
											Interactable StoredVariable1066 = ((Interactable)prop1065.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
											if(StoredVariable1066 != null)
											{
												OperandVar1067 = StoredVariable1066;
											}
										}
									}
									subContext1063.TargetInteractable = (Interactable)( (OperandVar1067));
								}
							}
							UnityEngine.GameObject OperandVar1068 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar1068 = FuncCtx1062;
							UnityEngine.GameObject OperandVar1069 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar1069 = ctx;
							External.SetParent((UnityEngine.GameObject)( (OperandVar1068)),(UnityEngine.GameObject)( (OperandVar1069)));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class inquisitor_basic_resources : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1071 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable1070 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable1070 != null)
			{
				applicable = true;
				OperandVar1071 = applicable;
			}
			return (System.Boolean) (OperandVar1071);
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
			
			
			External.Gold = (System.Int32)( (100f));
			
			External.Influence = (System.Int32)( (50f));
			
			External.Sanity = (System.Int32)( (100f));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_check_lose : EventAction {
        
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
			
			System.Boolean OperandVar1080 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable1072 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable1072 != null)
			{
				Markers StoredVariable1073 = ((Markers)StoredVariable1072.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable1073 != null)
				{
					System.Boolean ifResult1074; //IsContext = False IsNew = False
					
					
					System.Int32 OperandVar1076 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop1075 = External.CurrentDate(); //IsContext = False IsNew = False
					OperandVar1076 = prop1075;
					
					
					
					System.Boolean OperandVar1079 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar1077 = default(System.String); //IsContext = False IsNew = False
					OperandVar1077 = "lost";
					System.Boolean prop1078 = StoredVariable1073.HasMarker( (OperandVar1077)); //IsContext = False IsNew = False
					OperandVar1079 = prop1078;
					if(ifResult1074 = ( (( ( (OperandVar1076))) > ( ( (0f))))) && ( (!(OperandVar1079))))
					{
						applicable = true;
						OperandVar1080 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar1080);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Int32 OperandVar1082 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop1081 = External.Sanity; //IsContext = False IsNew = False
			OperandVar1082 = prop1081;
			
			
			if(( ( (OperandVar1082))) == ( ( (0f))))
			{
				System.String OperandVar1083 = default(System.String); //IsContext = False IsNew = False
				OperandVar1083 = "you_in_the_cult_now";
				External.Lose(( (OperandVar1083)).ToString());
				
				{
					Markers subContext1084 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext1084 ContextSwitchInterpreter
					if(subContext1084 != null)
					{
						
						System.String OperandVar1085 = default(System.String); //IsContext = False IsNew = False
						OperandVar1085 = "lost";
						subContext1084.SetMarker(( (OperandVar1085)).ToString());
					}
				}
			}
			
			System.Int32 OperandVar1087 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop1086 = External.Influence; //IsContext = False IsNew = False
			OperandVar1087 = prop1086;
			
			
			if(( ( (OperandVar1087))) == ( ( (0f))))
			{
				System.String OperandVar1088 = default(System.String); //IsContext = False IsNew = False
				OperandVar1088 = "they_fired_you";
				External.Lose(( (OperandVar1088)).ToString());
				
				{
					Markers subContext1089 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext1089 ContextSwitchInterpreter
					if(subContext1089 != null)
					{
						
						System.String OperandVar1090 = default(System.String); //IsContext = False IsNew = False
						OperandVar1090 = "lost";
						subContext1089.SetMarker(( (OperandVar1090)).ToString());
					}
				}
			}
			System.Boolean OperandVar1102 = default(System.Boolean); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> OperandVar1092 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> prop1091 = External.AllActors; //IsContext = False IsNew = False
			if(prop1091 != null)
			{
				OperandVar1092 = prop1091;
			}
			System.Boolean prop1101 = External.Any( (OperandVar1092),(UnityEngine.GameObject go)=>{;
;
System.Boolean OperandVar1096 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.noble OperandVar1094 = default(Blackboards.noble); //IsContext = False IsNew = False;
Blackboards.noble StoredVariable1093 = ((Blackboards.noble)go.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False;
if(StoredVariable1093 != null)
				{
					OperandVar1094 = StoredVariable1093;
				};
System.Boolean prop1095 = External.Has( (OperandVar1094)); //IsContext = False IsNew = False;
OperandVar1096 = prop1095;;
;
System.Boolean OperandVar1100 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.cultist OperandVar1098 = default(Blackboards.cultist); //IsContext = False IsNew = False;
Blackboards.cultist StoredVariable1097 = ((Blackboards.cultist)go.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False;
if(StoredVariable1097 != null)
				{
					OperandVar1098 = StoredVariable1097;
				};
System.Boolean prop1099 = External.Has( (OperandVar1098)); //IsContext = False IsNew = False;
OperandVar1100 = prop1099;;
return ( ( (OperandVar1096))) && ( (!(OperandVar1100)));}); //IsContext = False IsNew = False
			OperandVar1102 = prop1101;
			System.Boolean not_everyone_is_a_cultist =  (OperandVar1102); //IsContext = False IsNew = False
			System.Boolean OperandVar1103 = default(System.Boolean); //IsContext = False IsNew = False
			OperandVar1103 = not_everyone_is_a_cultist;
			if(!(OperandVar1103))
			{
				System.String OperandVar1104 = default(System.String); //IsContext = False IsNew = False
				OperandVar1104 = "everyone_is_a_cultist";
				External.Lose(( (OperandVar1104)).ToString());
				
				{
					Markers subContext1105 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext1105 ContextSwitchInterpreter
					if(subContext1105 != null)
					{
						
						System.String OperandVar1106 = default(System.String); //IsContext = False IsNew = False
						OperandVar1106 = "lost";
						subContext1105.SetMarker(( (OperandVar1106)).ToString());
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class lose_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1110 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable1107 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable1107 != null)
			{
				UnityEngine.GameObject prop1108 = StoredVariable1107.ShowedObject; //IsContext = False IsNew = False
				if(prop1108 != null)
				{
					LostEvent StoredVariable1109 = ((LostEvent)prop1108.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
					if(StoredVariable1109 != null)
					{
						applicable = true;
						OperandVar1110 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar1110);
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
				EncounterUi subContext1111 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext1111 ContextSwitchInterpreter
				if(subContext1111 != null)
				{
					
					System.String OperandVar1116 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable1112 = ((EncounterUi)subContext1111.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable1112 != null)
					{
						UnityEngine.GameObject prop1113 = StoredVariable1112.ShowedObject; //IsContext = False IsNew = False
						if(prop1113 != null)
						{
							LostEvent StoredVariable1114 = ((LostEvent)prop1113.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
							if(StoredVariable1114 != null)
							{
								System.String prop1115 = StoredVariable1114.Why; //IsContext = False IsNew = False
								if(prop1115 != null)
								{
									OperandVar1116 = prop1115;
								}
							}
						}
					}
					subContext1111.Description = (System.String)( (OperandVar1116));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class win_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1120 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable1117 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable1117 != null)
			{
				UnityEngine.GameObject prop1118 = StoredVariable1117.ShowedObject; //IsContext = False IsNew = False
				if(prop1118 != null)
				{
					WinEvent StoredVariable1119 = ((WinEvent)prop1118.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
					if(StoredVariable1119 != null)
					{
						applicable = true;
						OperandVar1120 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar1120);
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
				EncounterUi subContext1121 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext1121 ContextSwitchInterpreter
				if(subContext1121 != null)
				{
					
					System.String OperandVar1126 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable1122 = ((EncounterUi)subContext1121.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable1122 != null)
					{
						UnityEngine.GameObject prop1123 = StoredVariable1122.ShowedObject; //IsContext = False IsNew = False
						if(prop1123 != null)
						{
							WinEvent StoredVariable1124 = ((WinEvent)prop1123.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
							if(StoredVariable1124 != null)
							{
								System.String prop1125 = StoredVariable1124.Why; //IsContext = False IsNew = False
								if(prop1125 != null)
								{
									OperandVar1126 = prop1125;
								}
							}
						}
					}
					subContext1121.Description = (System.String)( (OperandVar1126));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class notify_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1130 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable1127 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable1127 != null)
			{
				UnityEngine.GameObject prop1128 = StoredVariable1127.ShowedObject; //IsContext = False IsNew = False
				if(prop1128 != null)
				{
					NotifyEvent StoredVariable1129 = ((NotifyEvent)prop1128.GetComponent(typeof(NotifyEvent))); //IsContext = False IsNew = False
					if(StoredVariable1129 != null)
					{
						applicable = true;
						OperandVar1130 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar1130);
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
				EncounterUi subContext1131 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext1131 ContextSwitchInterpreter
				if(subContext1131 != null)
				{
					
					System.String OperandVar1136 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable1132 = ((EncounterUi)subContext1131.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable1132 != null)
					{
						UnityEngine.GameObject prop1133 = StoredVariable1132.ShowedObject; //IsContext = False IsNew = False
						if(prop1133 != null)
						{
							NotifyEvent StoredVariable1134 = ((NotifyEvent)prop1133.GetComponent(typeof(NotifyEvent))); //IsContext = False IsNew = False
							if(StoredVariable1134 != null)
							{
								System.String prop1135 = StoredVariable1134.OfWhat; //IsContext = False IsNew = False
								if(prop1135 != null)
								{
									OperandVar1136 = prop1135;
								}
							}
						}
					}
					subContext1131.Description = (System.String)( (OperandVar1136));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class turn_gold : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1138 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable1137 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable1137 != null)
			{
				applicable = true;
				OperandVar1138 = applicable;
			}
			return (System.Boolean) (OperandVar1138);
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
			
			for (int i1139 = 0; External.AllActors != null && i1139 < External.AllActors.Count; i1139++)
			{
				UnityEngine.GameObject iter1140 = External.AllActors[i1139]; //IsContext = True IsNew = True
				
				{
					//ContextStatement UnityEngine.GameObject iter1140 ContextSwitchInterpreter
					if(iter1140 != null)
					{
						
						
						{
							Blackboards.noble subContext1141 = (Blackboards.noble)iter1140.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
							//ContextStatement Blackboards.noble subContext1141 ContextSwitchInterpreter
							if(subContext1141 != null)
							{
								
								
								System.Int32 OperandVar1143 = default(System.Int32); //IsContext = False IsNew = False
								System.Int32 prop1142 = External.Gold; //IsContext = False IsNew = False
								OperandVar1143 = prop1142;
								
								System.Single OperandVar1146 = default(System.Single); //IsContext = False IsNew = False
								Blackboards.noble StoredVariable1144 = ((Blackboards.noble)subContext1141.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
								if(StoredVariable1144 != null)
								{
									System.Single prop1145 = StoredVariable1144.Loyalty; //IsContext = False IsNew = False
									OperandVar1146 = prop1145;
								}
								
								External.Gold = (System.Int32)(( ( (OperandVar1143))) + ( (( (OperandVar1146)) * ( (3f)))));
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_check_win : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1152 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable1147 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable1147 != null)
			{
				System.Boolean ifResult1148; //IsContext = False IsNew = False
				System.Boolean OperandVar1151 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar1149 = default(System.String); //IsContext = False IsNew = False
				OperandVar1149 = "check_win";
				System.Boolean prop1150 = StoredVariable1147.HasMarker( (OperandVar1149)); //IsContext = False IsNew = False
				OperandVar1151 = prop1150;
				if(ifResult1148 =  (OperandVar1151))
				{
					applicable = true;
					OperandVar1152 = applicable;
				}
			}
			return (System.Boolean) (OperandVar1152);
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
			
			System.Boolean OperandVar1160 = default(System.Boolean); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> OperandVar1154 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
			System.Collections.Generic.List<UnityEngine.GameObject> prop1153 = External.AllActors; //IsContext = False IsNew = False
			if(prop1153 != null)
			{
				OperandVar1154 = prop1153;
			}
			System.Boolean prop1159 = External.Any( (OperandVar1154),(UnityEngine.GameObject go)=>{;
System.Boolean OperandVar1158 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.cultist OperandVar1156 = default(Blackboards.cultist); //IsContext = False IsNew = False;
Blackboards.cultist StoredVariable1155 = ((Blackboards.cultist)go.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False;
if(StoredVariable1155 != null)
				{
					OperandVar1156 = StoredVariable1155;
				};
System.Boolean prop1157 = External.Has( (OperandVar1156)); //IsContext = False IsNew = False;
OperandVar1158 = prop1157;;
return  (OperandVar1158);}); //IsContext = False IsNew = False
			OperandVar1160 = prop1159;
			System.Boolean any_cultists_left =  (OperandVar1160); //IsContext = False IsNew = False
		}
        }
    }
}
