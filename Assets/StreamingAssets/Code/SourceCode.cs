namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_agents : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable0 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
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
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class country_cities : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar7 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable2 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable2 != null)
			{
				System.Boolean ifResult3; //IsContext = False IsNew = False
				System.Boolean OperandVar6 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar4 = default(System.String); //IsContext = False IsNew = False
				OperandVar4 = "country_node";
				System.Boolean prop5 = StoredVariable2.HasMarker( (OperandVar4)); //IsContext = False IsNew = False
				OperandVar6 = prop5;
				if(ifResult3 =  (OperandVar6))
				{
					applicable = true;
					OperandVar7 = applicable;
				}
			}
			return (System.Boolean) (OperandVar7);
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
			Entity EntVar8 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar8 != null) EntVar8.ComponentAdded();
			System.Single OperandVar10 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop9 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
			OperandVar10 = prop9;
			for (int i = 0; i <  (OperandVar10); i++)
			{
				UnityEngine.GameObject city_obj = new UnityEngine.GameObject("city_obj"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject city_obj11 = city_obj; //IsContext = True IsNew = False
					Entity AddContext12 = (Entity)city_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Entity AddContext12 ContextSwitchInterpreter
						if(AddContext12 != null)
						{
							UnityEngine.Vector3 OperandVar18 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
							System.Single OperandVar14 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop13 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar14 = prop13;
							System.Single OperandVar16 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop15 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar16 = prop15;
							UnityEngine.Vector3 prop17 = External.Vec( (OperandVar14), (OperandVar16)); //IsContext = False IsNew = False
							OperandVar18 = prop17;
							AddContext12.Position = (UnityEngine.Vector3)( (OperandVar18));
						}
					}
					Place AddContext19 = (Place)city_obj.AddComponent(typeof(Place)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Place AddContext19 ContextSwitchInterpreter
						if(AddContext19 != null)
						{
							
							AddContext19.Size = (System.Int32)( (100f));
						}
					}
					Named AddContext20 = (Named)city_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Named AddContext20 ContextSwitchInterpreter
						if(AddContext20 != null)
						{
							System.String OperandVar21 = default(System.String); //IsContext = False IsNew = False
							OperandVar21 = "main_name";
							
							System.String OperandVar24 = default(System.String); //IsContext = False IsNew = False
							System.String OperandVar22 = default(System.String); //IsContext = False IsNew = False
							OperandVar22 = "country_name";
							System.String prop23 = External.RandomName( (OperandVar22)); //IsContext = False IsNew = False
							if(prop23 != null)
							{
								OperandVar24 = prop23;
							}
							AddContext20.Set(( (OperandVar21)).ToString(),(System.Single)( (0f)),( (OperandVar24)).ToString());
						}
					}
					Interactables AddContext25 = (Interactables)city_obj.AddComponent(typeof(Interactables)); //IsContext = True IsNew = True
					Interactable AddContext26 = (Interactable)city_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
					Blackboards.city AddContext27 = (Blackboards.city)city_obj.AddComponent(typeof(Blackboards.city)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.city AddContext27 ContextSwitchInterpreter
						if(AddContext27 != null)
						{
							System.Single OperandVar29 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop28 = External.Random( (3f), (6f)); //IsContext = False IsNew = False
							OperandVar29 = prop28;
							AddContext27.Size = (System.Int32)( (OperandVar29));
							UnityEngine.GameObject OperandVar30 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar30 = root;
							AddContext27.Of = (UnityEngine.GameObject)( (OperandVar30));
						}
					}
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
			
			System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable31 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				System.Boolean ifResult32; //IsContext = False IsNew = False
				
				System.Boolean OperandVar35 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar33 = default(System.String); //IsContext = False IsNew = False
				OperandVar33 = "cult_node";
				System.Boolean prop34 = StoredVariable31.HasMarker( (OperandVar33)); //IsContext = False IsNew = False
				OperandVar35 = prop34;
				
				System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> OperandVar37 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> prop36 = External.AllActors; //IsContext = False IsNew = False
				if(prop36 != null)
				{
					OperandVar37 = prop36;
				}
				System.Boolean prop42 = External.Any( (OperandVar37),(UnityEngine.GameObject go)=>{;
System.Boolean OperandVar41 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.noble OperandVar39 = default(Blackboards.noble); //IsContext = False IsNew = False;
Blackboards.noble StoredVariable38 = ((Blackboards.noble)go.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False;
if(StoredVariable38 != null)
					{
						OperandVar39 = StoredVariable38;
					};
System.Boolean prop40 = External.Has( (OperandVar39)); //IsContext = False IsNew = False;
OperandVar41 = prop40;;
return  (OperandVar41);}); //IsContext = False IsNew = False
				OperandVar43 = prop42;
				if(ifResult32 = ( ( (OperandVar35))) && ( ( (OperandVar43))))
				{
					applicable = true;
					OperandVar44 = applicable;
				}
			}
			return (System.Boolean) (OperandVar44);
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
			for (int i45 = 0; External.AllActors != null && i45 < External.AllActors.Count; i45++)
			{
				UnityEngine.GameObject iter46 = External.AllActors[i45]; //IsContext = True IsNew = True
				
				{
					//ContextStatement UnityEngine.GameObject iter46 ContextSwitchInterpreter
					if(iter46 != null)
					{
						
						{
							Blackboards.noble subContext47 = (Blackboards.noble)iter46.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
							//ContextStatement Blackboards.noble subContext47 ContextSwitchInterpreter
							if(subContext47 != null)
							{
								
								System.Single OperandVar48 = default(System.Single); //IsContext = False IsNew = False
								OperandVar48 = current_noble;
								
								System.Single OperandVar49 = default(System.Single); //IsContext = False IsNew = False
								OperandVar49 = noble_per_cultist;
								if(( ( (OperandVar48))) >= ( ( (OperandVar49))))
								{
									
									current_noble =  (0f);
									
									
									
									Blackboards.noble OperandVar50 = default(Blackboards.noble); //IsContext = False IsNew = False
									OperandVar50 = subContext47;
									External.Log((System.Object)(( ( ("cultist = "))) + ( ( (OperandVar50)))));
									Blackboards.cultist ContextVar51 = iter46.AddComponent<Blackboards.cultist>();; //IsContext = False IsNew = True
									
									{
										//ContextStatement Blackboards.cultist ContextVar51 ContextSwitchInterpreter
										if(ContextVar51 != null)
										{
											
											
											System.Single OperandVar53 = default(System.Single); //IsContext = False IsNew = False
											if(subContext47 != null)
											{
												System.Single prop52 = subContext47.Knowledge; //IsContext = False IsNew = False
												OperandVar53 = prop52;
											}
											
											System.Single OperandVar55 = default(System.Single); //IsContext = False IsNew = False
											if(subContext47 != null)
											{
												System.Single prop54 = subContext47.Occult; //IsContext = False IsNew = False
												OperandVar55 = prop54;
											}
											
											ContextVar51.Power = (System.Single)(( (( ( (OperandVar53))) + ( ( (OperandVar55))))) / ( (2f)));
										}
									}
									Entity EntVar56 = (Entity)iter46.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
									if(EntVar56 != null) EntVar56.ComponentAdded();
								}
								
								System.Single OperandVar57 = default(System.Single); //IsContext = False IsNew = False
								OperandVar57 = current_noble;
								
								
								current_noble = ( ( (OperandVar57))) + ( ( (1f)));
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
			
			System.Boolean OperandVar79 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable58 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable58 != null)
			{
				Blackboards.noble StoredVariable59 = ((Blackboards.noble)StoredVariable58.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable59 != null)
				{
					System.Boolean ifResult60; //IsContext = False IsNew = False
					
					System.Boolean OperandVar62 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable58 != null)
					{
						System.Boolean prop61 = StoredVariable58.Generated; //IsContext = False IsNew = False
						OperandVar62 = prop61;
					}
					
					
					System.Int32 OperandVar64 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop63 = External.CurrentDate(); //IsContext = False IsNew = False
					OperandVar64 = prop63;
					
					
					
					System.Boolean OperandVar68 = default(System.Boolean); //IsContext = False IsNew = False
					Blackboards.cultist OperandVar66 = default(Blackboards.cultist); //IsContext = False IsNew = False
					Blackboards.cultist StoredVariable65 = ((Blackboards.cultist)StoredVariable59.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
					if(StoredVariable65 != null)
					{
						OperandVar66 = StoredVariable65;
					}
					System.Boolean prop67 = External.Has( (OperandVar66)); //IsContext = False IsNew = False
					OperandVar68 = prop67;
					
					System.Boolean OperandVar78 = default(System.Boolean); //IsContext = False IsNew = False
					System.Collections.Generic.List<UnityEngine.GameObject> OperandVar72 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
					UnityEngine.GameObject prop69 = StoredVariable59.Where; //IsContext = False IsNew = False
					if(prop69 != null)
					{
						Interactables StoredVariable70 = ((Interactables)prop69.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
						if(StoredVariable70 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop71 = StoredVariable70.Every; //IsContext = False IsNew = False
							if(prop71 != null)
							{
								OperandVar72 = prop71;
							}
						}
					}
					System.Boolean prop77 = External.Any( (OperandVar72),(UnityEngine.GameObject go)=>{;
System.Boolean OperandVar76 = default(System.Boolean); //IsContext = False IsNew = False;
Blackboards.cultist OperandVar74 = default(Blackboards.cultist); //IsContext = False IsNew = False;
Blackboards.cultist StoredVariable73 = ((Blackboards.cultist)go.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False;
if(StoredVariable73 != null)
						{
							OperandVar74 = StoredVariable73;
						};
System.Boolean prop75 = External.Has( (OperandVar74)); //IsContext = False IsNew = False;
OperandVar76 = prop75;;
return  (OperandVar76);}); //IsContext = False IsNew = False
					OperandVar78 = prop77;
					if(ifResult60 = ( (!(OperandVar62))) && ( (( ( (OperandVar64))) > ( ( (0f))))) && ( (!(OperandVar68))) && ( ( (OperandVar78))))
					{
						applicable = true;
						OperandVar79 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar79);
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
			
			
			System.Single OperandVar81 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop80 = External.Random( (0f), (5f)); //IsContext = False IsNew = False
			OperandVar81 = prop80;
			
			
			if(( ( (OperandVar81))) > ( ( (2f))))
			{
				root.AddComponent<Blackboards.cultist>();
				Entity EntVar82 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
				if(EntVar82 != null) EntVar82.ComponentAdded();
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
			
			System.Boolean OperandVar88 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable83 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable83 != null)
			{
				Blackboards.cultist StoredVariable84 = ((Blackboards.cultist)StoredVariable83.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
				if(StoredVariable84 != null)
				{
					System.Boolean ifResult85; //IsContext = False IsNew = False
					System.Boolean OperandVar87 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable83 != null)
					{
						System.Boolean prop86 = StoredVariable83.IsActive; //IsContext = False IsNew = False
						OperandVar87 = prop86;
					}
					if(ifResult85 =  (OperandVar87))
					{
						applicable = true;
						OperandVar88 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar88);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar91 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.cultist StoredVariable89 = ((Blackboards.cultist)root.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
			if(StoredVariable89 != null)
			{
				System.Single prop90 = StoredVariable89.Power; //IsContext = False IsNew = False
				OperandVar91 = prop90;
			}
			return (System.Single) (OperandVar91);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject cast_ritual = new UnityEngine.GameObject("cast_ritual"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cast_ritual92 = cast_ritual; //IsContext = True IsNew = False
				Event AddContext93 = (Event)cast_ritual.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext93 ContextSwitchInterpreter
					if(AddContext93 != null)
					{
						UnityEngine.GameObject OperandVar94 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar94 = root;
						AddContext93.Context = (UnityEngine.GameObject)( (OperandVar94));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cast_ritual, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cultist_try_convert_other : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar100 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable95 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable95 != null)
			{
				Blackboards.cultist StoredVariable96 = ((Blackboards.cultist)StoredVariable95.GetComponent(typeof(Blackboards.cultist))); //IsContext = False IsNew = False
				if(StoredVariable96 != null)
				{
					System.Boolean ifResult97; //IsContext = False IsNew = False
					System.Boolean OperandVar99 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable95 != null)
					{
						System.Boolean prop98 = StoredVariable95.IsActive; //IsContext = False IsNew = False
						OperandVar99 = prop98;
					}
					if(ifResult97 =  (OperandVar99))
					{
						applicable = true;
						OperandVar100 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar100);
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
			
			UnityEngine.GameObject convert_other = new UnityEngine.GameObject("convert_other"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject convert_other101 = convert_other; //IsContext = True IsNew = False
				Event AddContext102 = (Event)convert_other.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext102 ContextSwitchInterpreter
					if(AddContext102 != null)
					{
						UnityEngine.GameObject OperandVar103 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar103 = root;
						AddContext102.Context = (UnityEngine.GameObject)( (OperandVar103));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(convert_other, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_enc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar105 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable104 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable104 != null)
			{
				applicable = true;
				OperandVar105 = applicable;
			}
			return (System.Boolean) (OperandVar105);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
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
			
			System.Boolean OperandVar113 = default(System.Boolean); //IsContext = False IsNew = False
			Interactables StoredVariable106 = ((Interactables)root.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
			if(StoredVariable106 != null)
			{
				Blackboards.city StoredVariable107 = ((Blackboards.city)StoredVariable106.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
				if(StoredVariable107 != null)
				{
					System.Boolean ifResult108; //IsContext = False IsNew = False
					
					System.Int32 OperandVar110 = default(System.Int32); //IsContext = False IsNew = False
					if(StoredVariable106 != null)
					{
						System.Int32 prop109 = StoredVariable106.Count; //IsContext = False IsNew = False
						OperandVar110 = prop109;
					}
					
					System.Int32 OperandVar112 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop111 = StoredVariable107.Size; //IsContext = False IsNew = False
					OperandVar112 = prop111;
					if(ifResult108 = ( ( (OperandVar110))) < ( ( (OperandVar112))))
					{
						applicable = true;
						OperandVar113 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar113);
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
				UnityEngine.GameObject noble_obj114 = noble_obj; //IsContext = True IsNew = False
				Actor AddContext115 = (Actor)noble_obj.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Entity AddContext116 = (Entity)noble_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext117 = (Markers)noble_obj.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Blackboards.personality AddContext118 = (Blackboards.personality)noble_obj.AddComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = True
				Interactable AddContext119 = (Interactable)noble_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
				Blackboards.noble AddContext120 = (Blackboards.noble)noble_obj.AddComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.noble AddContext120 ContextSwitchInterpreter
					if(AddContext120 != null)
					{
						UnityEngine.GameObject OperandVar123 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.city StoredVariable121 = ((Blackboards.city)root.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
						if(StoredVariable121 != null)
						{
							UnityEngine.GameObject prop122 = StoredVariable121.Of; //IsContext = False IsNew = False
							if(prop122 != null)
							{
								OperandVar123 = prop122;
							}
						}
						AddContext120.Of = (UnityEngine.GameObject)( (OperandVar123));
						UnityEngine.GameObject OperandVar124 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar124 = root;
						AddContext120.Where = (UnityEngine.GameObject)( (OperandVar124));
					}
				}
				Named AddContext125 = (Named)noble_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext125 ContextSwitchInterpreter
					if(AddContext125 != null)
					{
						System.String OperandVar126 = default(System.String); //IsContext = False IsNew = False
						OperandVar126 = "main_name";
						
						System.String OperandVar129 = default(System.String); //IsContext = False IsNew = False
						System.String OperandVar127 = default(System.String); //IsContext = False IsNew = False
						OperandVar127 = "human_name";
						System.String prop128 = External.RandomName( (OperandVar127)); //IsContext = False IsNew = False
						if(prop128 != null)
						{
							OperandVar129 = prop128;
						}
						AddContext125.Set(( (OperandVar126)).ToString(),(System.Single)( (0f)),( (OperandVar129)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(noble_obj, 0.1f);
			
			{
				Interactables subContext130 = (Interactables)root.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
				//ContextStatement Interactables subContext130 ContextSwitchInterpreter
				if(subContext130 != null)
				{
					UnityEngine.GameObject OperandVar131 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar131 = noble_obj;
					subContext130.Attach((UnityEngine.GameObject)( (OperandVar131)));
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
			
			System.Boolean OperandVar146 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable132 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable132 != null)
			{
				Named StoredVariable133 = ((Named)StoredVariable132.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable133 != null)
				{
					System.Boolean ifResult134; //IsContext = False IsNew = False
					
					Blackboards.country OperandVar137 = default(Blackboards.country); //IsContext = False IsNew = False
					if(StoredVariable132 != null)
					{
						UnityEngine.GameObject prop135 = StoredVariable132.Of; //IsContext = False IsNew = False
						if(prop135 != null)
						{
							Blackboards.country StoredVariable136 = ((Blackboards.country)prop135.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable136 != null)
							{
								OperandVar137 = StoredVariable136;
							}
						}
					}
					
					System.Boolean OperandVar145 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable132 != null)
					{
						UnityEngine.GameObject prop138 = StoredVariable132.Of; //IsContext = False IsNew = False
						if(prop138 != null)
						{
							Blackboards.country StoredVariable139 = ((Blackboards.country)prop138.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable139 != null)
							{
								System.Boolean ifResult140; //IsContext = False IsNew = False
								System.Boolean OperandVar144 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject OperandVar142 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								UnityEngine.GameObject prop141 = StoredVariable139.Emperor; //IsContext = False IsNew = False
								if(prop141 != null)
								{
									OperandVar142 = prop141;
								}
								System.Boolean prop143 = External.Has( (OperandVar142)); //IsContext = False IsNew = False
								OperandVar144 = prop143;
								if(ifResult140 = !(OperandVar144))
								{
									OperandVar145 = ifResult140;
								}
							}
						}
					}
					if(ifResult134 = ( ( (OperandVar137))) && ( ( (OperandVar145))))
					{
						applicable = true;
						OperandVar146 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar146);
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
				Named subContext147 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext147 ContextSwitchInterpreter
				if(subContext147 != null)
				{
					System.String OperandVar148 = default(System.String); //IsContext = False IsNew = False
					OperandVar148 = "postfix";
					
					
					subContext147.Set(( (OperandVar148)).ToString(),(System.Single)( (1f)),( (", the Emperor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext149 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext149 ContextSwitchInterpreter
				if(subContext149 != null)
				{
					System.Single OperandVar151 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop150 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar151 = prop150;
					subContext149.Loyalty = (System.Single)( (OperandVar151));
					System.Single OperandVar153 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop152 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar153 = prop152;
					subContext149.Sanity = (System.Single)( (OperandVar153));
					System.Single OperandVar155 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop154 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar155 = prop154;
					subContext149.Influence = (System.Single)( (OperandVar155));
					System.Single OperandVar157 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop156 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar157 = prop156;
					subContext149.Knowledge = (System.Single)( (OperandVar157));
					System.Single OperandVar159 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop158 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar159 = prop158;
					subContext149.Occult = (System.Single)( (OperandVar159));
				}
			}
			
			{
				Blackboards.noble subContext160 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext160 ContextSwitchInterpreter
				if(subContext160 != null)
				{
					
					{
						UnityEngine.GameObject subContext161 = subContext160.Of; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext161 ContextPropertySwitchInterpreter
						if(subContext161 != null)
						{
							
							{
								Blackboards.country subContext162 = (Blackboards.country)subContext161.GetComponent(typeof(Blackboards.country)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.country subContext162 ContextSwitchInterpreter
								if(subContext162 != null)
								{
									UnityEngine.GameObject OperandVar163 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar163 = root;
									subContext162.Emperor = (UnityEngine.GameObject)( (OperandVar163));
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
			
			System.Boolean OperandVar166 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable164 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable164 != null)
			{
				Named StoredVariable165 = ((Named)StoredVariable164.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable165 != null)
				{
					applicable = true;
					OperandVar166 = applicable;
				}
			}
			return (System.Boolean) (OperandVar166);
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
				Named subContext167 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext167 ContextSwitchInterpreter
				if(subContext167 != null)
				{
					System.String OperandVar168 = default(System.String); //IsContext = False IsNew = False
					OperandVar168 = "postfix";
					
					
					subContext167.Set(( (OperandVar168)).ToString(),(System.Single)( (1f)),( (", an inquisitor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext169 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext169 ContextSwitchInterpreter
				if(subContext169 != null)
				{
					System.Single OperandVar171 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop170 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar171 = prop170;
					subContext169.Loyalty = (System.Single)( (OperandVar171));
					System.Single OperandVar173 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop172 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar173 = prop172;
					subContext169.Sanity = (System.Single)( (OperandVar173));
					System.Single OperandVar175 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop174 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar175 = prop174;
					subContext169.Influence = (System.Single)( (OperandVar175));
					System.Single OperandVar177 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop176 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar177 = prop176;
					subContext169.Knowledge = (System.Single)( (OperandVar177));
					System.Single OperandVar179 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop178 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar179 = prop178;
					subContext169.Occult = (System.Single)( (OperandVar179));
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
			
			System.Boolean OperandVar182 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable180 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable180 != null)
			{
				Named StoredVariable181 = ((Named)StoredVariable180.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable181 != null)
				{
					applicable = true;
					OperandVar182 = applicable;
				}
			}
			return (System.Boolean) (OperandVar182);
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
				Named subContext183 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext183 ContextSwitchInterpreter
				if(subContext183 != null)
				{
					System.String OperandVar184 = default(System.String); //IsContext = False IsNew = False
					OperandVar184 = "postfix";
					
					
					subContext183.Set(( (OperandVar184)).ToString(),(System.Single)( (1f)),( (", a trader")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext185 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext185 ContextSwitchInterpreter
				if(subContext185 != null)
				{
					System.Single OperandVar187 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop186 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar187 = prop186;
					subContext185.Loyalty = (System.Single)( (OperandVar187));
					System.Single OperandVar189 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop188 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar189 = prop188;
					subContext185.Sanity = (System.Single)( (OperandVar189));
					System.Single OperandVar191 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop190 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar191 = prop190;
					subContext185.Influence = (System.Single)( (OperandVar191));
					System.Single OperandVar193 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop192 = External.Random( (0.4f), (0.5f)); //IsContext = False IsNew = False
					OperandVar193 = prop192;
					subContext185.Knowledge = (System.Single)( (OperandVar193));
					System.Single OperandVar195 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop194 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar195 = prop194;
					subContext185.Occult = (System.Single)( (OperandVar195));
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
			
			System.Boolean OperandVar198 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable196 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable196 != null)
			{
				Named StoredVariable197 = ((Named)StoredVariable196.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable197 != null)
				{
					applicable = true;
					OperandVar198 = applicable;
				}
			}
			return (System.Boolean) (OperandVar198);
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
				Named subContext199 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext199 ContextSwitchInterpreter
				if(subContext199 != null)
				{
					System.String OperandVar200 = default(System.String); //IsContext = False IsNew = False
					OperandVar200 = "postfix";
					
					
					subContext199.Set(( (OperandVar200)).ToString(),(System.Single)( (1f)),( (", an aristocrat")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext201 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext201 ContextSwitchInterpreter
				if(subContext201 != null)
				{
					System.Single OperandVar203 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop202 = External.Random( (0.5f), (0.6f)); //IsContext = False IsNew = False
					OperandVar203 = prop202;
					subContext201.Loyalty = (System.Single)( (OperandVar203));
					System.Single OperandVar205 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop204 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar205 = prop204;
					subContext201.Sanity = (System.Single)( (OperandVar205));
					System.Single OperandVar207 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop206 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar207 = prop206;
					subContext201.Influence = (System.Single)( (OperandVar207));
					System.Single OperandVar209 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop208 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar209 = prop208;
					subContext201.Knowledge = (System.Single)( (OperandVar209));
					System.Single OperandVar211 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop210 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar211 = prop210;
					subContext201.Occult = (System.Single)( (OperandVar211));
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
			
			System.Boolean OperandVar214 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable212 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable212 != null)
			{
				Named StoredVariable213 = ((Named)StoredVariable212.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable213 != null)
				{
					applicable = true;
					OperandVar214 = applicable;
				}
			}
			return (System.Boolean) (OperandVar214);
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
				Named subContext215 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext215 ContextSwitchInterpreter
				if(subContext215 != null)
				{
					System.String OperandVar216 = default(System.String); //IsContext = False IsNew = False
					OperandVar216 = "postfix";
					
					
					subContext215.Set(( (OperandVar216)).ToString(),(System.Single)( (1f)),( (", a governor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext217 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext217 ContextSwitchInterpreter
				if(subContext217 != null)
				{
					System.Single OperandVar219 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop218 = External.Random( (0.2f), (0.6f)); //IsContext = False IsNew = False
					OperandVar219 = prop218;
					subContext217.Loyalty = (System.Single)( (OperandVar219));
					System.Single OperandVar221 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop220 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar221 = prop220;
					subContext217.Sanity = (System.Single)( (OperandVar221));
					System.Single OperandVar223 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop222 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar223 = prop222;
					subContext217.Influence = (System.Single)( (OperandVar223));
					System.Single OperandVar225 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop224 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar225 = prop224;
					subContext217.Knowledge = (System.Single)( (OperandVar225));
					System.Single OperandVar227 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop226 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar227 = prop226;
					subContext217.Occult = (System.Single)( (OperandVar227));
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
			
			System.Boolean OperandVar230 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable228 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable228 != null)
			{
				Named StoredVariable229 = ((Named)StoredVariable228.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable229 != null)
				{
					applicable = true;
					OperandVar230 = applicable;
				}
			}
			return (System.Boolean) (OperandVar230);
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
				Named subContext231 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext231 ContextSwitchInterpreter
				if(subContext231 != null)
				{
					System.String OperandVar232 = default(System.String); //IsContext = False IsNew = False
					OperandVar232 = "postfix";
					
					
					subContext231.Set(( (OperandVar232)).ToString(),(System.Single)( (1f)),( (", a general")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext233 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext233 ContextSwitchInterpreter
				if(subContext233 != null)
				{
					System.Single OperandVar235 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop234 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar235 = prop234;
					subContext233.Loyalty = (System.Single)( (OperandVar235));
					System.Single OperandVar237 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop236 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar237 = prop236;
					subContext233.Sanity = (System.Single)( (OperandVar237));
					System.Single OperandVar239 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop238 = External.Random( (0.3f), (0.4f)); //IsContext = False IsNew = False
					OperandVar239 = prop238;
					subContext233.Influence = (System.Single)( (OperandVar239));
					System.Single OperandVar241 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop240 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar241 = prop240;
					subContext233.Knowledge = (System.Single)( (OperandVar241));
					System.Single OperandVar243 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop242 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar243 = prop242;
					subContext233.Occult = (System.Single)( (OperandVar243));
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
			
			System.Boolean OperandVar246 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable244 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable244 != null)
			{
				Named StoredVariable245 = ((Named)StoredVariable244.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable245 != null)
				{
					applicable = true;
					OperandVar246 = applicable;
				}
			}
			return (System.Boolean) (OperandVar246);
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
				Named subContext247 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext247 ContextSwitchInterpreter
				if(subContext247 != null)
				{
					System.String OperandVar248 = default(System.String); //IsContext = False IsNew = False
					OperandVar248 = "postfix";
					
					
					subContext247.Set(( (OperandVar248)).ToString(),(System.Single)( (1f)),( (", an alchemist")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext249 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext249 ContextSwitchInterpreter
				if(subContext249 != null)
				{
					System.Single OperandVar251 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop250 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar251 = prop250;
					subContext249.Loyalty = (System.Single)( (OperandVar251));
					System.Single OperandVar253 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop252 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar253 = prop252;
					subContext249.Sanity = (System.Single)( (OperandVar253));
					System.Single OperandVar255 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop254 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar255 = prop254;
					subContext249.Influence = (System.Single)( (OperandVar255));
					System.Single OperandVar257 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop256 = External.Random( (0.3f), (1f)); //IsContext = False IsNew = False
					OperandVar257 = prop256;
					subContext249.Knowledge = (System.Single)( (OperandVar257));
					System.Single OperandVar259 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop258 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar259 = prop258;
					subContext249.Occult = (System.Single)( (OperandVar259));
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
			
			System.Boolean OperandVar262 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable260 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable260 != null)
			{
				Named StoredVariable261 = ((Named)StoredVariable260.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable261 != null)
				{
					applicable = true;
					OperandVar262 = applicable;
				}
			}
			return (System.Boolean) (OperandVar262);
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
				Named subContext263 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext263 ContextSwitchInterpreter
				if(subContext263 != null)
				{
					System.String OperandVar264 = default(System.String); //IsContext = False IsNew = False
					OperandVar264 = "postfix";
					
					
					subContext263.Set(( (OperandVar264)).ToString(),(System.Single)( (1f)),( (", a mage")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext265 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext265 ContextSwitchInterpreter
				if(subContext265 != null)
				{
					System.Single OperandVar267 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop266 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar267 = prop266;
					subContext265.Loyalty = (System.Single)( (OperandVar267));
					System.Single OperandVar269 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop268 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar269 = prop268;
					subContext265.Sanity = (System.Single)( (OperandVar269));
					System.Single OperandVar271 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop270 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar271 = prop270;
					subContext265.Influence = (System.Single)( (OperandVar271));
					System.Single OperandVar273 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop272 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar273 = prop272;
					subContext265.Knowledge = (System.Single)( (OperandVar273));
					System.Single OperandVar275 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop274 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar275 = prop274;
					subContext265.Occult = (System.Single)( (OperandVar275));
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
			
			System.Boolean OperandVar278 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable276 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable276 != null)
			{
				Named StoredVariable277 = ((Named)StoredVariable276.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable277 != null)
				{
					applicable = true;
					OperandVar278 = applicable;
				}
			}
			return (System.Boolean) (OperandVar278);
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
				Named subContext279 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext279 ContextSwitchInterpreter
				if(subContext279 != null)
				{
					System.String OperandVar280 = default(System.String); //IsContext = False IsNew = False
					OperandVar280 = "postfix";
					
					
					subContext279.Set(( (OperandVar280)).ToString(),(System.Single)( (1f)),( (", a priest")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext281 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext281 ContextSwitchInterpreter
				if(subContext281 != null)
				{
					System.Single OperandVar283 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop282 = External.Random( (0.9f), (1f)); //IsContext = False IsNew = False
					OperandVar283 = prop282;
					subContext281.Loyalty = (System.Single)( (OperandVar283));
					System.Single OperandVar285 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop284 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar285 = prop284;
					subContext281.Sanity = (System.Single)( (OperandVar285));
					System.Single OperandVar287 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop286 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar287 = prop286;
					subContext281.Influence = (System.Single)( (OperandVar287));
					System.Single OperandVar289 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop288 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar289 = prop288;
					subContext281.Knowledge = (System.Single)( (OperandVar289));
					System.Single OperandVar291 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop290 = External.Random( (0f), (0f)); //IsContext = False IsNew = False
					OperandVar291 = prop290;
					subContext281.Occult = (System.Single)( (OperandVar291));
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
			
			System.Boolean OperandVar293 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable292 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable292 != null)
			{
				applicable = true;
				OperandVar293 = applicable;
			}
			return (System.Boolean) (OperandVar293);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Int32 OperandVar295 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop294 = External.Influence; //IsContext = False IsNew = False
			OperandVar295 = prop294;
			
			
			System.Single OperandVar298 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable296 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable296 != null)
			{
				System.Single prop297 = StoredVariable296.Influence; //IsContext = False IsNew = False
				OperandVar298 = prop297;
			}
			return (System.Single)( (( (OperandVar295)) * ( (0.01f)))) - ( ( (OperandVar298)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Boolean is_cultist =  (false); //IsContext = False IsNew = False
			
			{
				Blackboards.cultist subContext299 = (Blackboards.cultist)root.GetComponent(typeof(Blackboards.cultist)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.cultist subContext299 ContextSwitchInterpreter
				if(subContext299 != null)
				{
					
					is_cultist =  (true);
					
					System.Int32 OperandVar301 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop300 = External.Influence; //IsContext = False IsNew = False
					OperandVar301 = prop300;
					
					System.Single OperandVar304 = default(System.Single); //IsContext = False IsNew = False
					Blackboards.noble StoredVariable302 = ((Blackboards.noble)subContext299.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
					if(StoredVariable302 != null)
					{
						System.Single prop303 = StoredVariable302.Influence; //IsContext = False IsNew = False
						OperandVar304 = prop303;
					}
					
					External.Influence = (System.Int32)(( ( (OperandVar301))) + ( (( (OperandVar304)) * ( (10f)))));
					
					System.String notify =  ("it was a cultist!"); //IsContext = False IsNew = False
				}
			}
			System.Boolean OperandVar305 = default(System.Boolean); //IsContext = False IsNew = False
			OperandVar305 = is_cultist;
			if(!(OperandVar305))
			{
				
				System.Int32 OperandVar307 = default(System.Int32); //IsContext = False IsNew = False
				System.Int32 prop306 = External.Influence; //IsContext = False IsNew = False
				OperandVar307 = prop306;
				
				System.Single OperandVar310 = default(System.Single); //IsContext = False IsNew = False
				Blackboards.noble StoredVariable308 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
				if(StoredVariable308 != null)
				{
					System.Single prop309 = StoredVariable308.Influence; //IsContext = False IsNew = False
					OperandVar310 = prop309;
				}
				
				External.Influence = (System.Int32)(( ( (OperandVar307))) - ( (( (OperandVar310)) * ( (20f)))));
			}
			Blackboards.noble OperandVar312 = default(Blackboards.noble); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable311 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable311 != null)
			{
				OperandVar312 = StoredVariable311;
			}
			External.Destroy((UnityEngine.Object)( (OperandVar312)));
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
			
			System.Boolean OperandVar319 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable313 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable313 != null)
			{
				System.Boolean ifResult314; //IsContext = False IsNew = False
				System.Boolean OperandVar318 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged OperandVar316 = default(Blackboards.aged); //IsContext = False IsNew = False
				Blackboards.aged StoredVariable315 = ((Blackboards.aged)StoredVariable313.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
				if(StoredVariable315 != null)
				{
					OperandVar316 = StoredVariable315;
				}
				System.Boolean prop317 = External.Has( (OperandVar316)); //IsContext = False IsNew = False
				OperandVar318 = prop317;
				if(ifResult314 = !(OperandVar318))
				{
					applicable = true;
					OperandVar319 = applicable;
				}
			}
			return (System.Boolean) (OperandVar319);
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
			
			Blackboards.aged ContextVar320 = root.AddComponent<Blackboards.aged>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.aged ContextVar320 ContextSwitchInterpreter
				if(ContextVar320 != null)
				{
					System.Single OperandVar322 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop321 = External.Random( (20f), (50f)); //IsContext = False IsNew = False
					OperandVar322 = prop321;
					ContextVar320.Age = (System.Int32)( (OperandVar322));
				}
			}
			Entity EntVar323 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar323 != null) EntVar323.ComponentAdded();
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
			
			System.Boolean OperandVar330 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable324 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable324 != null)
			{
				Blackboards.personality StoredVariable325 = ((Blackboards.personality)StoredVariable324.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable325 != null)
				{
					Blackboards.aged StoredVariable326 = ((Blackboards.aged)StoredVariable325.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable326 != null)
					{
						System.Boolean ifResult327; //IsContext = False IsNew = False
						
						System.Int32 OperandVar329 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop328 = StoredVariable326.CurAge; //IsContext = False IsNew = False
						OperandVar329 = prop328;
						
						
						if(ifResult327 = ( ( (OperandVar329))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar330 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar330);
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
				Blackboards.aged subContext331 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext331 ContextSwitchInterpreter
				if(subContext331 != null)
				{
					
					System.Int32 OperandVar333 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop332 = subContext331.CurAge; //IsContext = False IsNew = False
					OperandVar333 = prop332;
					
					
					subContext331.CurAge = (System.Int32)(( ( (OperandVar333))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext334 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext334 ContextSwitchInterpreter
				if(subContext334 != null)
				{
					
					System.Single OperandVar336 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop335 = subContext334.Cruel; //IsContext = False IsNew = False
					OperandVar336 = prop335;
					
					
					subContext334.Cruel = (System.Single)(( ( (OperandVar336))) + ( ( (0.1f))));
					
					System.Single OperandVar338 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop337 = subContext334.Reckless; //IsContext = False IsNew = False
					OperandVar338 = prop337;
					
					
					subContext334.Reckless = (System.Single)(( ( (OperandVar338))) + ( ( (0.1f))));
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
			
			System.Boolean OperandVar345 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable339 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable339 != null)
			{
				Blackboards.personality StoredVariable340 = ((Blackboards.personality)StoredVariable339.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable340 != null)
				{
					Blackboards.aged StoredVariable341 = ((Blackboards.aged)StoredVariable340.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable341 != null)
					{
						System.Boolean ifResult342; //IsContext = False IsNew = False
						
						System.Int32 OperandVar344 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop343 = StoredVariable341.CurAge; //IsContext = False IsNew = False
						OperandVar344 = prop343;
						
						
						if(ifResult342 = ( ( (OperandVar344))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar345 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar345);
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
				Blackboards.aged subContext346 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext346 ContextSwitchInterpreter
				if(subContext346 != null)
				{
					
					System.Int32 OperandVar348 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop347 = subContext346.CurAge; //IsContext = False IsNew = False
					OperandVar348 = prop347;
					
					
					subContext346.CurAge = (System.Int32)(( ( (OperandVar348))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext349 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext349 ContextSwitchInterpreter
				if(subContext349 != null)
				{
					
					System.Single OperandVar351 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop350 = subContext349.Brave; //IsContext = False IsNew = False
					OperandVar351 = prop350;
					
					
					subContext349.Brave = (System.Single)(( ( (OperandVar351))) - ( ( (0.1f))));
					
					System.Single OperandVar353 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop352 = subContext349.Optimistic; //IsContext = False IsNew = False
					OperandVar353 = prop352;
					
					
					subContext349.Optimistic = (System.Single)(( ( (OperandVar353))) + ( ( (0.2f))));
					
					System.Single OperandVar355 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop354 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar355 = prop354;
					
					
					if(( ( (OperandVar355))) > ( ( (0.9f))))
					{
						
						System.Single OperandVar357 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop356 = subContext349.Cruel; //IsContext = False IsNew = False
						OperandVar357 = prop356;
						
						
						subContext349.Cruel = (System.Single)(( ( (OperandVar357))) + ( ( (0.1f))));
					}
					
					System.Single OperandVar359 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop358 = subContext349.Ambitious; //IsContext = False IsNew = False
					OperandVar359 = prop358;
					
					
					subContext349.Ambitious = (System.Single)(( ( (OperandVar359))) - ( ( (0.03f))));
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
			
			System.Boolean OperandVar366 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable360 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable360 != null)
			{
				Blackboards.personality StoredVariable361 = ((Blackboards.personality)StoredVariable360.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable361 != null)
				{
					Blackboards.aged StoredVariable362 = ((Blackboards.aged)StoredVariable361.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable362 != null)
					{
						System.Boolean ifResult363; //IsContext = False IsNew = False
						
						System.Int32 OperandVar365 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop364 = StoredVariable362.CurAge; //IsContext = False IsNew = False
						OperandVar365 = prop364;
						
						
						if(ifResult363 = ( ( (OperandVar365))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar366 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar366);
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
				Blackboards.aged subContext367 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext367 ContextSwitchInterpreter
				if(subContext367 != null)
				{
					
					System.Int32 OperandVar369 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop368 = subContext367.CurAge; //IsContext = False IsNew = False
					OperandVar369 = prop368;
					
					
					subContext367.CurAge = (System.Int32)(( ( (OperandVar369))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext370 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext370 ContextSwitchInterpreter
				if(subContext370 != null)
				{
					
					System.Single OperandVar372 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop371 = subContext370.Brave; //IsContext = False IsNew = False
					OperandVar372 = prop371;
					
					
					subContext370.Brave = (System.Single)(( ( (OperandVar372))) + ( ( (0.2f))));
					
					System.Single OperandVar374 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop373 = subContext370.Optimistic; //IsContext = False IsNew = False
					OperandVar374 = prop373;
					
					
					subContext370.Optimistic = (System.Single)(( ( (OperandVar374))) + ( ( (0.5f))));
					
					System.Single OperandVar376 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop375 = subContext370.Ambitious; //IsContext = False IsNew = False
					OperandVar376 = prop375;
					
					
					subContext370.Ambitious = (System.Single)(( ( (OperandVar376))) + ( ( (0.2f))));
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
			
			System.Boolean OperandVar383 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable377 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable377 != null)
			{
				Blackboards.personality StoredVariable378 = ((Blackboards.personality)StoredVariable377.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable378 != null)
				{
					Blackboards.aged StoredVariable379 = ((Blackboards.aged)StoredVariable378.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable379 != null)
					{
						System.Boolean ifResult380; //IsContext = False IsNew = False
						
						System.Int32 OperandVar382 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop381 = StoredVariable379.CurAge; //IsContext = False IsNew = False
						OperandVar382 = prop381;
						
						
						if(ifResult380 = ( ( (OperandVar382))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar383 = applicable;
						}
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
				Blackboards.aged subContext384 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext384 ContextSwitchInterpreter
				if(subContext384 != null)
				{
					
					System.Int32 OperandVar386 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop385 = subContext384.CurAge; //IsContext = False IsNew = False
					OperandVar386 = prop385;
					
					
					subContext384.CurAge = (System.Int32)(( ( (OperandVar386))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext387 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext387 ContextSwitchInterpreter
				if(subContext387 != null)
				{
					
					System.Single OperandVar389 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop388 = subContext387.Rational; //IsContext = False IsNew = False
					OperandVar389 = prop388;
					
					
					subContext387.Rational = (System.Single)(( ( (OperandVar389))) + ( ( (0.1f))));
					
					System.Single OperandVar391 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop390 = subContext387.Ambitious; //IsContext = False IsNew = False
					OperandVar391 = prop390;
					
					
					subContext387.Ambitious = (System.Single)(( ( (OperandVar391))) + ( ( (0.05f))));
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
			
			System.Boolean OperandVar398 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable392 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable392 != null)
			{
				Blackboards.personality StoredVariable393 = ((Blackboards.personality)StoredVariable392.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable393 != null)
				{
					Blackboards.aged StoredVariable394 = ((Blackboards.aged)StoredVariable393.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable394 != null)
					{
						System.Boolean ifResult395; //IsContext = False IsNew = False
						
						System.Int32 OperandVar397 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop396 = StoredVariable394.CurAge; //IsContext = False IsNew = False
						OperandVar397 = prop396;
						
						
						if(ifResult395 = ( ( (OperandVar397))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar398 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar398);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar401 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable399 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable399 != null)
			{
				System.Single prop400 = StoredVariable399.Brave; //IsContext = False IsNew = False
				OperandVar401 = prop400;
			}
			
			System.Single OperandVar403 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable399 != null)
			{
				System.Single prop402 = StoredVariable399.Ambitious; //IsContext = False IsNew = False
				OperandVar403 = prop402;
			}
			
			System.Single OperandVar405 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable399 != null)
			{
				System.Single prop404 = StoredVariable399.Cruel; //IsContext = False IsNew = False
				OperandVar405 = prop404;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar401))) + ( ( (OperandVar403))) - ( ( (OperandVar405)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext406 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext406 ContextSwitchInterpreter
				if(subContext406 != null)
				{
					
					System.Int32 OperandVar408 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop407 = subContext406.CurAge; //IsContext = False IsNew = False
					OperandVar408 = prop407;
					
					System.Single OperandVar410 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop409 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar410 = prop409;
					subContext406.CurAge = (System.Int32)(( ( (OperandVar408))) + ( ( (OperandVar410))));
				}
			}
			
			{
				Blackboards.personality subContext411 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext411 ContextSwitchInterpreter
				if(subContext411 != null)
				{
					
					System.Single OperandVar413 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop412 = subContext411.Brave; //IsContext = False IsNew = False
					OperandVar413 = prop412;
					
					
					subContext411.Brave = (System.Single)(( ( (OperandVar413))) + ( ( (0.3f))));
					
					System.Single OperandVar415 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop414 = subContext411.Rational; //IsContext = False IsNew = False
					OperandVar415 = prop414;
					
					
					subContext411.Rational = (System.Single)(( ( (OperandVar415))) - ( ( (0.1f))));
					
					System.Single OperandVar417 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop416 = subContext411.Optimistic; //IsContext = False IsNew = False
					OperandVar417 = prop416;
					
					
					subContext411.Optimistic = (System.Single)(( ( (OperandVar417))) + ( ( (0.3f))));
					
					System.Single OperandVar419 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop418 = subContext411.Ambitious; //IsContext = False IsNew = False
					OperandVar419 = prop418;
					
					
					subContext411.Ambitious = (System.Single)(( ( (OperandVar419))) + ( ( (0.1f))));
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
			
			System.Boolean OperandVar426 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable420 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable420 != null)
			{
				Blackboards.personality StoredVariable421 = ((Blackboards.personality)StoredVariable420.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable421 != null)
				{
					Blackboards.aged StoredVariable422 = ((Blackboards.aged)StoredVariable421.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable422 != null)
					{
						System.Boolean ifResult423; //IsContext = False IsNew = False
						
						System.Int32 OperandVar425 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop424 = StoredVariable422.CurAge; //IsContext = False IsNew = False
						OperandVar425 = prop424;
						
						
						if(ifResult423 = ( ( (OperandVar425))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar426 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar426);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar429 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable427 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable427 != null)
			{
				System.Single prop428 = StoredVariable427.Rational; //IsContext = False IsNew = False
				OperandVar429 = prop428;
			}
			
			System.Single OperandVar431 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable427 != null)
			{
				System.Single prop430 = StoredVariable427.Brave; //IsContext = False IsNew = False
				OperandVar431 = prop430;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar429))) - ( ( (OperandVar431)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext432 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext432 ContextSwitchInterpreter
				if(subContext432 != null)
				{
					
					System.Int32 OperandVar434 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop433 = subContext432.CurAge; //IsContext = False IsNew = False
					OperandVar434 = prop433;
					
					System.Single OperandVar436 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop435 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar436 = prop435;
					subContext432.CurAge = (System.Int32)(( ( (OperandVar434))) + ( ( (OperandVar436))));
				}
			}
			
			{
				Blackboards.personality subContext437 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext437 ContextSwitchInterpreter
				if(subContext437 != null)
				{
					
					System.Single OperandVar439 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop438 = subContext437.Brave; //IsContext = False IsNew = False
					OperandVar439 = prop438;
					
					
					subContext437.Brave = (System.Single)(( ( (OperandVar439))) - ( ( (0.1f))));
					
					System.Single OperandVar441 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop440 = subContext437.Rational; //IsContext = False IsNew = False
					OperandVar441 = prop440;
					
					
					subContext437.Rational = (System.Single)(( ( (OperandVar441))) + ( ( (0.5f))));
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
			
			System.Boolean OperandVar448 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable442 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable442 != null)
			{
				Blackboards.personality StoredVariable443 = ((Blackboards.personality)StoredVariable442.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable443 != null)
				{
					Blackboards.aged StoredVariable444 = ((Blackboards.aged)StoredVariable443.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable444 != null)
					{
						System.Boolean ifResult445; //IsContext = False IsNew = False
						
						System.Int32 OperandVar447 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop446 = StoredVariable444.CurAge; //IsContext = False IsNew = False
						OperandVar447 = prop446;
						
						
						if(ifResult445 = ( ( (OperandVar447))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar448 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar448);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar451 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable449 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable449 != null)
			{
				System.Single prop450 = StoredVariable449.Rational; //IsContext = False IsNew = False
				OperandVar451 = prop450;
			}
			
			System.Single OperandVar453 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable449 != null)
			{
				System.Single prop452 = StoredVariable449.Ambitious; //IsContext = False IsNew = False
				OperandVar453 = prop452;
			}
			
			return (System.Single)( ( (0.2f))) + ( ( (OperandVar451))) + ( (( (OperandVar453)) * ( (2f))));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext454 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext454 ContextSwitchInterpreter
				if(subContext454 != null)
				{
					
					System.Int32 OperandVar456 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop455 = subContext454.CurAge; //IsContext = False IsNew = False
					OperandVar456 = prop455;
					
					System.Single OperandVar458 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop457 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar458 = prop457;
					subContext454.CurAge = (System.Int32)(( ( (OperandVar456))) + ( ( (OperandVar458))));
				}
			}
			
			{
				Blackboards.personality subContext459 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext459 ContextSwitchInterpreter
				if(subContext459 != null)
				{
					
					System.Single OperandVar461 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop460 = subContext459.Brave; //IsContext = False IsNew = False
					OperandVar461 = prop460;
					
					
					subContext459.Brave = (System.Single)(( ( (OperandVar461))) - ( ( (0.2f))));
					
					System.Single OperandVar463 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop462 = subContext459.Ambitious; //IsContext = False IsNew = False
					OperandVar463 = prop462;
					
					
					subContext459.Ambitious = (System.Single)(( ( (OperandVar463))) + ( ( (0.3f))));
					
					System.Single OperandVar465 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop464 = subContext459.Reckless; //IsContext = False IsNew = False
					OperandVar465 = prop464;
					
					
					subContext459.Reckless = (System.Single)(( ( (OperandVar465))) + ( ( (0.2f))));
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
			
			System.Boolean OperandVar472 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable466 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable466 != null)
			{
				Blackboards.personality StoredVariable467 = ((Blackboards.personality)StoredVariable466.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable467 != null)
				{
					Blackboards.aged StoredVariable468 = ((Blackboards.aged)StoredVariable467.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable468 != null)
					{
						System.Boolean ifResult469; //IsContext = False IsNew = False
						
						System.Int32 OperandVar471 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop470 = StoredVariable468.CurAge; //IsContext = False IsNew = False
						OperandVar471 = prop470;
						
						
						if(ifResult469 = ( ( (OperandVar471))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar472 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar472);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar475 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable473 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable473 != null)
			{
				System.Single prop474 = StoredVariable473.Cruel; //IsContext = False IsNew = False
				OperandVar475 = prop474;
			}
			
			return (System.Single)( (OperandVar475)) * ( (0.8f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext476 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext476 ContextSwitchInterpreter
				if(subContext476 != null)
				{
					
					System.Int32 OperandVar478 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop477 = subContext476.CurAge; //IsContext = False IsNew = False
					OperandVar478 = prop477;
					
					System.Single OperandVar480 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop479 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar480 = prop479;
					subContext476.CurAge = (System.Int32)(( ( (OperandVar478))) + ( ( (OperandVar480))));
				}
			}
			
			{
				Blackboards.personality subContext481 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext481 ContextSwitchInterpreter
				if(subContext481 != null)
				{
					
					System.Single OperandVar483 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop482 = subContext481.Rational; //IsContext = False IsNew = False
					OperandVar483 = prop482;
					
					
					subContext481.Rational = (System.Single)(( ( (OperandVar483))) - ( ( (0.1f))));
					
					System.Single OperandVar485 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop484 = subContext481.Cruel; //IsContext = False IsNew = False
					OperandVar485 = prop484;
					
					
					subContext481.Cruel = (System.Single)(( ( (OperandVar485))) + ( ( (0.5f))));
					
					System.Single OperandVar487 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop486 = subContext481.Reckless; //IsContext = False IsNew = False
					OperandVar487 = prop486;
					
					
					subContext481.Reckless = (System.Single)(( ( (OperandVar487))) + ( ( (0.5f))));
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
			
			System.Boolean OperandVar501 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable488 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable488 != null)
			{
				Markers StoredVariable489 = ((Markers)StoredVariable488.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable489 != null)
				{
					System.Boolean ifResult490; //IsContext = False IsNew = False
					
					System.Boolean OperandVar497 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable488 != null)
					{
						UnityEngine.GameObject prop491 = StoredVariable488.ShowedObject; //IsContext = False IsNew = False
						if(prop491 != null)
						{
							System.Boolean ifResult492; //IsContext = False IsNew = False
							System.Boolean OperandVar496 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar494 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable493 = ((Named)prop491.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable493 != null)
							{
								OperandVar494 = StoredVariable493;
							}
							System.Boolean prop495 = External.Has( (OperandVar494)); //IsContext = False IsNew = False
							OperandVar496 = prop495;
							if(ifResult492 =  (OperandVar496))
							{
								OperandVar497 = ifResult492;
							}
						}
					}
					
					System.Boolean OperandVar500 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar498 = default(System.String); //IsContext = False IsNew = False
					OperandVar498 = "named_ui_marker";
					System.Boolean prop499 = StoredVariable489.HasMarker( (OperandVar498)); //IsContext = False IsNew = False
					OperandVar500 = prop499;
					if(ifResult490 = ( ( (OperandVar497))) && ( (!(OperandVar500))))
					{
						applicable = true;
						OperandVar501 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar501);
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
			
			UnityEngine.GameObject OperandVar502 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar502 = root;
			UnityEngine.GameObject ctx =  (OperandVar502); //IsContext = False IsNew = False
			
			{
				BarsManager subContext503 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext503 ContextSwitchInterpreter
				if(subContext503 != null)
				{
					UnityEngine.GameObject OperandVar505 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop504 = subContext503.GetLeftBar(); //IsContext = False IsNew = False
					if(prop504 != null)
					{
						OperandVar505 = prop504;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar505); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							System.Boolean OperandVar509 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar507 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable506 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable506 != null)
							{
								OperandVar507 = StoredVariable506;
							}
							System.Boolean prop508 = External.Has( (OperandVar507)); //IsContext = False IsNew = False
							OperandVar509 = prop508;
							if( (OperandVar509))
							{
								UnityEngine.GameObject OperandVar510 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar510 = p_ctx;
								ctx =  (OperandVar510);
							}
						}
					}
				}
			}
			
			{
				Markers subContext511 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext511 ContextSwitchInterpreter
				if(subContext511 != null)
				{
					System.String OperandVar512 = default(System.String); //IsContext = False IsNew = False
					OperandVar512 = "named_ui_marker";
					subContext511.SetUiMarker(( (OperandVar512)).ToString());
				}
			}
			
			{
				//ContextStatement UnityEngine.GameObject ctx ContextSwitchInterpreter
				if(ctx != null)
				{
					
					{
						UiObject subContext513 = (UiObject)ctx.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
						//ContextStatement UiObject subContext513 ContextSwitchInterpreter
						if(subContext513 != null)
						{
							Named OperandVar516 = default(Named); //IsContext = False IsNew = False
							UnityEngine.GameObject prop514 = subContext513.ShowedObject; //IsContext = False IsNew = False
							if(prop514 != null)
							{
								Named StoredVariable515 = ((Named)prop514.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable515 != null)
								{
									OperandVar516 = StoredVariable515;
								}
							}
							Named showed_named =  (OperandVar516); //IsContext = False IsNew = False
							TextField ContextVar517 = ctx.AddComponent<TextField>();; //IsContext = False IsNew = True
							
							{
								//ContextStatement TextField ContextVar517 ContextSwitchInterpreter
								if(ContextVar517 != null)
								{
									System.String OperandVar519 = default(System.String); //IsContext = False IsNew = False
									System.String prop518 = showed_named.FullName; //IsContext = False IsNew = False
									if(prop518 != null)
									{
										OperandVar519 = prop518;
									}
									ContextVar517.Show(( (OperandVar519)).ToString());
									
									{
										//ContextStatement Named showed_named ContextSwitchInterpreter
										if(showed_named != null)
										{
											VoidDelegate Lambda520 = () => 
											{
												System.String OperandVar522 = default(System.String); //IsContext = False IsNew = False
												System.String prop521 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop521 != null)
												{
													OperandVar522 = prop521;
												}
												ContextVar517.Show(( (OperandVar522)).ToString());
											};
											showed_named.OnUpdate(Lambda520);
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext523 = ContextVar517.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext523 ContextPropertySwitchInterpreter
										if(subContext523 != null)
										{
											
											subContext523.minHeight = (System.Single)( (20f));
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext524 = ContextVar517.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext524 ContextPropertySwitchInterpreter
										if(subContext524 != null)
										{
											
											subContext524.minWidth = (System.Single)( (100f));
										}
									}
								}
							}
							Entity EntVar525 = (Entity)ctx.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
							if(EntVar525 != null) EntVar525.ComponentAdded();
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar534 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable526 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable526 != null)
			{
				Place StoredVariable527 = ((Place)StoredVariable526.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable527 != null)
				{
					System.Boolean ifResult528; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar530 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop529 = StoredVariable527.Agents; //IsContext = False IsNew = False
					if(prop529 != null)
					{
						OperandVar530 = prop529;
					}
					
					
					
					System.Boolean OperandVar533 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar531 = default(System.String); //IsContext = False IsNew = False
					OperandVar531 = "agents_pool";
					System.Boolean prop532 = StoredVariable526.HasMarker( (OperandVar531)); //IsContext = False IsNew = False
					OperandVar533 = prop532;
					if(ifResult528 = ( (( ( (OperandVar530 != null ? OperandVar530.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar533))))
					{
						applicable = true;
						OperandVar534 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar534);
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
				Place subContext535 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext535 ContextSwitchInterpreter
				if(subContext535 != null)
				{
					
					subContext535.Size = (System.Int32)( (5f));
					System.Single OperandVar537 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop536 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar537 = prop536;
					for (int i = 0; i <  (OperandVar537); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag538 = ag; //IsContext = True IsNew = False
							Entity AddContext539 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext540 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext541 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext541 ContextSwitchInterpreter
								if(AddContext541 != null)
								{
									System.Single OperandVar543 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop542 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar543 = prop542;
									AddContext541.Age = (System.Int32)( (OperandVar543));
								}
							}
							Named AddContext544 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext544 ContextSwitchInterpreter
								if(AddContext544 != null)
								{
									
									
									
									AddContext544.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar547 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar545 = default(System.String); //IsContext = False IsNew = False
									OperandVar545 = "human_name";
									System.String prop546 = External.RandomName( (OperandVar545)); //IsContext = False IsNew = False
									if(prop546 != null)
									{
										OperandVar547 = prop546;
									}
									AddContext544.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar547)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar549 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable548 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable548 != null)
						{
							OperandVar549 = StoredVariable548;
						}
						subContext535.Attach((Agent)( (OperandVar549)));
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
			
			System.Boolean OperandVar556 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable550 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable550 != null)
			{
				System.Boolean ifResult551; //IsContext = False IsNew = False
				System.Boolean OperandVar555 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar553 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable552 = ((Blackboards.event_marker)StoredVariable550.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable552 != null)
				{
					OperandVar553 = StoredVariable552;
				}
				System.Boolean prop554 = External.Has( (OperandVar553)); //IsContext = False IsNew = False
				OperandVar555 = prop554;
				if(ifResult551 = !(OperandVar555))
				{
					applicable = true;
					OperandVar556 = applicable;
				}
			}
			return (System.Boolean) (OperandVar556);
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
			Entity EntVar557 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar557 != null) EntVar557.ComponentAdded();
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
			
			System.Boolean OperandVar559 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable558 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable558 != null)
			{
				applicable = true;
				OperandVar559 = applicable;
			}
			return (System.Boolean) (OperandVar559);
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
			
			UnityEngine.GameObject OperandVar560 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar560 = root;
			External.MapEnlistDetailed((UnityEngine.GameObject)( (OperandVar560)));
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
			
			System.Boolean OperandVar567 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable561 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable561 != null)
			{
				Markers StoredVariable562 = ((Markers)StoredVariable561.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable562 != null)
				{
					System.Boolean ifResult563; //IsContext = False IsNew = False
					System.Boolean OperandVar566 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar564 = default(System.String); //IsContext = False IsNew = False
					OperandVar564 = "encounter_ui_enlist";
					System.Boolean prop565 = StoredVariable562.HasMarker( (OperandVar564)); //IsContext = False IsNew = False
					OperandVar566 = prop565;
					if(ifResult563 = !(OperandVar566))
					{
						applicable = true;
						OperandVar567 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar567);
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
				Markers subContext568 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext568 ContextSwitchInterpreter
				if(subContext568 != null)
				{
					System.String OperandVar569 = default(System.String); //IsContext = False IsNew = False
					OperandVar569 = "encounter_ui_enlist";
					subContext568.SetUiMarker(( (OperandVar569)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar570 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar570 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar570)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar576 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable571 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable571 != null)
			{
				Named StoredVariable572 = ((Named)StoredVariable571.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable572 != null)
				{
					System.Boolean ifResult573; //IsContext = False IsNew = False
					
					System.Boolean OperandVar575 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable571 != null)
					{
						System.Boolean prop574 = StoredVariable571.Act; //IsContext = False IsNew = False
						OperandVar575 = prop574;
					}
					
					
					if(ifResult573 = ( ( (OperandVar575))) == ( ( (true))))
					{
						applicable = true;
						OperandVar576 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar576);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject enc = new UnityEngine.GameObject("enc"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject enc577 = enc; //IsContext = True IsNew = False
				Encounter AddContext578 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext578 ContextSwitchInterpreter
					if(AddContext578 != null)
					{
						UnityEngine.GameObject OperandVar579 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar579 = root;
						AddContext578.Context = (UnityEngine.GameObject)( (OperandVar579));
					}
				}
				Markers AddContext580 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext581 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext582 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext582 ContextSwitchInterpreter
					if(AddContext582 != null)
					{
						System.String OperandVar583 = default(System.String); //IsContext = False IsNew = False
						OperandVar583 = "main_name";
						
						
						AddContext582.Set(( (OperandVar583)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc, 0.1f);
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
			
			System.Boolean OperandVar597 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable584 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable584 != null)
			{
				Markers StoredVariable585 = ((Markers)StoredVariable584.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable585 != null)
				{
					System.Boolean ifResult586; //IsContext = False IsNew = False
					
					System.Boolean OperandVar593 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable584 != null)
					{
						UnityEngine.GameObject prop587 = StoredVariable584.ShowedObject; //IsContext = False IsNew = False
						if(prop587 != null)
						{
							System.Boolean ifResult588; //IsContext = False IsNew = False
							System.Boolean OperandVar592 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar590 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable589 = ((Place)prop587.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable589 != null)
							{
								OperandVar590 = StoredVariable589;
							}
							System.Boolean prop591 = External.Has( (OperandVar590)); //IsContext = False IsNew = False
							OperandVar592 = prop591;
							if(ifResult588 =  (OperandVar592))
							{
								OperandVar593 = ifResult588;
							}
						}
					}
					
					System.Boolean OperandVar596 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar594 = default(System.String); //IsContext = False IsNew = False
					OperandVar594 = "place_ui_cards_list";
					System.Boolean prop595 = StoredVariable585.HasMarker( (OperandVar594)); //IsContext = False IsNew = False
					OperandVar596 = prop595;
					if(ifResult586 = ( ( (OperandVar593))) && ( (!(OperandVar596))))
					{
						applicable = true;
						OperandVar597 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar597);
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
			
			UnityEngine.GameObject OperandVar598 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar598 = root;
			UnityEngine.GameObject ctx =  (OperandVar598); //IsContext = False IsNew = False
			
			{
				BarsManager subContext599 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext599 ContextSwitchInterpreter
				if(subContext599 != null)
				{
					UnityEngine.GameObject OperandVar601 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop600 = subContext599.GetBottomBar(); //IsContext = False IsNew = False
					if(prop600 != null)
					{
						OperandVar601 = prop600;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar601); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							System.Boolean OperandVar605 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar603 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable602 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable602 != null)
							{
								OperandVar603 = StoredVariable602;
							}
							System.Boolean prop604 = External.Has( (OperandVar603)); //IsContext = False IsNew = False
							OperandVar605 = prop604;
							if( (OperandVar605))
							{
								UnityEngine.GameObject OperandVar606 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar606 = p_ctx;
								ctx =  (OperandVar606);
							}
						}
					}
				}
			}
			
			{
				Markers subContext607 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext607 ContextSwitchInterpreter
				if(subContext607 != null)
				{
					System.String OperandVar608 = default(System.String); //IsContext = False IsNew = False
					OperandVar608 = "place_ui_cards_list";
					subContext607.SetUiMarker(( (OperandVar608)).ToString());
				}
			}
			Place OperandVar612 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable609 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable609 != null)
			{
				UnityEngine.GameObject prop610 = StoredVariable609.ShowedObject; //IsContext = False IsNew = False
				if(prop610 != null)
				{
					Place StoredVariable611 = ((Place)prop610.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable611 != null)
					{
						OperandVar612 = StoredVariable611;
					}
				}
			}
			Place pl =  (OperandVar612); //IsContext = False IsNew = False
			System.String OperandVar613 = default(System.String); //IsContext = False IsNew = False
			OperandVar613 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx614 = External.SpawnPrefab(( (OperandVar613)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx614 ContextPropertySwitchInterpreter
				if(FuncCtx614 != null)
				{
					
					{
						AgentsUI subContext615 = (AgentsUI)FuncCtx614.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext615 ContextSwitchInterpreter
						if(subContext615 != null)
						{
							Place OperandVar616 = default(Place); //IsContext = False IsNew = False
							OperandVar616 = pl;
							subContext615.TargetPlace = (Place)( (OperandVar616));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext617 = (CardsHolderAgentsAdapter)FuncCtx614.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext617 ContextSwitchInterpreter
						if(subContext617 != null)
						{
							Place OperandVar618 = default(Place); //IsContext = False IsNew = False
							OperandVar618 = pl;
							subContext617.TargetPlace = (Place)( (OperandVar618));
						}
					}
					UnityEngine.GameObject OperandVar619 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar619 = FuncCtx614;
					UnityEngine.GameObject OperandVar620 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar620 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar619)),(UnityEngine.GameObject)( (OperandVar620)));
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
			
			System.Boolean OperandVar626 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable621 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable621 != null)
			{
				System.Boolean ifResult622; //IsContext = False IsNew = False
				System.Boolean OperandVar625 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop623 = StoredVariable621.ShowedObject; //IsContext = False IsNew = False
				if(prop623 != null)
				{
					Place StoredVariable624 = ((Place)prop623.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable624 != null)
					{
						applicable = true;
						OperandVar625 = applicable;
					}
				}
				if(ifResult622 =  (OperandVar625))
				{
					applicable = true;
					OperandVar626 = applicable;
				}
			}
			return (System.Boolean) (OperandVar626);
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
			
			UnityEngine.GameObject OperandVar627 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar627 = root;
			UnityEngine.GameObject ctx =  (OperandVar627); //IsContext = False IsNew = False
			
			{
				BarsManager subContext628 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext628 ContextSwitchInterpreter
				if(subContext628 != null)
				{
					UnityEngine.GameObject OperandVar630 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop629 = subContext628.GetLeftBar(); //IsContext = False IsNew = False
					if(prop629 != null)
					{
						OperandVar630 = prop629;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar630); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							System.Boolean OperandVar634 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar632 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable631 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable631 != null)
							{
								OperandVar632 = StoredVariable631;
							}
							System.Boolean prop633 = External.Has( (OperandVar632)); //IsContext = False IsNew = False
							OperandVar634 = prop633;
							if( (OperandVar634))
							{
								UnityEngine.GameObject OperandVar635 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar635 = p_ctx;
								ctx =  (OperandVar635);
							}
						}
					}
				}
			}
			
			{
				//ContextStatement UnityEngine.GameObject ctx ContextSwitchInterpreter
				if(ctx != null)
				{
					TextField ContextVar636 = ctx.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar636 ContextSwitchInterpreter
						if(ContextVar636 != null)
						{
							
							ContextVar636.Label = (System.String)( ("size"));
							System.Int32 OperandVar641 = default(System.Int32); //IsContext = False IsNew = False
							UiObject StoredVariable637 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable637 != null)
							{
								UnityEngine.GameObject prop638 = StoredVariable637.ShowedObject; //IsContext = False IsNew = False
								if(prop638 != null)
								{
									Place StoredVariable639 = ((Place)prop638.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable639 != null)
									{
										System.Int32 prop640 = StoredVariable639.Size; //IsContext = False IsNew = False
										OperandVar641 = prop640;
									}
								}
							}
							ContextVar636.Show(( (OperandVar641)).ToString());
							
							{
								UnityEngine.UI.LayoutElement subContext642 = ContextVar636.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext642 ContextPropertySwitchInterpreter
								if(subContext642 != null)
								{
									
									subContext642.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext643 = ContextVar636.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext643 ContextPropertySwitchInterpreter
								if(subContext643 != null)
								{
									
									subContext643.minWidth = (System.Single)( (100f));
								}
							}
						}
					}
					Entity EntVar644 = (Entity)ctx.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar644 != null) EntVar644.ComponentAdded();
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
			
			System.Boolean OperandVar654 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable645 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable645 != null)
			{
				System.Boolean ifResult646; //IsContext = False IsNew = False
				System.Boolean OperandVar653 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop647 = StoredVariable645.ShowedObject; //IsContext = False IsNew = False
				if(prop647 != null)
				{
					System.Boolean ifResult648; //IsContext = False IsNew = False
					System.Boolean OperandVar652 = default(System.Boolean); //IsContext = False IsNew = False
					Interactables OperandVar650 = default(Interactables); //IsContext = False IsNew = False
					Interactables StoredVariable649 = ((Interactables)prop647.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable649 != null)
					{
						OperandVar650 = StoredVariable649;
					}
					System.Boolean prop651 = External.Has( (OperandVar650)); //IsContext = False IsNew = False
					OperandVar652 = prop651;
					if(ifResult648 =  (OperandVar652))
					{
						OperandVar653 = ifResult648;
					}
				}
				if(ifResult646 =  (OperandVar653))
				{
					applicable = true;
					OperandVar654 = applicable;
				}
			}
			return (System.Boolean) (OperandVar654);
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
			
			UnityEngine.GameObject OperandVar655 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar655 = root;
			UnityEngine.GameObject ctx =  (OperandVar655); //IsContext = False IsNew = False
			
			{
				BarsManager subContext656 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext656 ContextSwitchInterpreter
				if(subContext656 != null)
				{
					UnityEngine.GameObject OperandVar658 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop657 = subContext656.GetTopBar(); //IsContext = False IsNew = False
					if(prop657 != null)
					{
						OperandVar658 = prop657;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar658); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							System.Boolean OperandVar662 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar660 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable659 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable659 != null)
							{
								OperandVar660 = StoredVariable659;
							}
							System.Boolean prop661 = External.Has( (OperandVar660)); //IsContext = False IsNew = False
							OperandVar662 = prop661;
							if( (OperandVar662))
							{
								UnityEngine.GameObject OperandVar663 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar663 = p_ctx;
								ctx =  (OperandVar663);
							}
						}
					}
				}
			}
			Interactables OperandVar667 = default(Interactables); //IsContext = False IsNew = False
			UiObject StoredVariable664 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable664 != null)
			{
				UnityEngine.GameObject prop665 = StoredVariable664.ShowedObject; //IsContext = False IsNew = False
				if(prop665 != null)
				{
					Interactables StoredVariable666 = ((Interactables)prop665.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable666 != null)
					{
						OperandVar667 = StoredVariable666;
					}
				}
			}
			Interactables inter =  (OperandVar667); //IsContext = False IsNew = False
			System.String OperandVar668 = default(System.String); //IsContext = False IsNew = False
			OperandVar668 = "interactables_ui";
			
			{
				UnityEngine.GameObject FuncCtx669 = External.SpawnPrefab(( (OperandVar668)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx669 ContextPropertySwitchInterpreter
				if(FuncCtx669 != null)
				{
					
					{
						InteractablesUI subContext670 = (InteractablesUI)FuncCtx669.GetComponent(typeof(InteractablesUI)); //IsContext = True IsNew = False
						//ContextStatement InteractablesUI subContext670 ContextSwitchInterpreter
						if(subContext670 != null)
						{
							Interactables OperandVar671 = default(Interactables); //IsContext = False IsNew = False
							OperandVar671 = inter;
							subContext670.TargetInteractables = (Interactables)( (OperandVar671));
						}
					}
					UnityEngine.GameObject OperandVar672 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar672 = FuncCtx669;
					UnityEngine.GameObject OperandVar673 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar673 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar672)),(UnityEngine.GameObject)( (OperandVar673)));
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
			
			System.Boolean OperandVar687 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable674 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable674 != null)
			{
				System.Boolean ifResult675; //IsContext = False IsNew = False
				
				System.Boolean OperandVar682 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop676 = StoredVariable674.ShowedObject; //IsContext = False IsNew = False
				if(prop676 != null)
				{
					System.Boolean ifResult677; //IsContext = False IsNew = False
					System.Boolean OperandVar681 = default(System.Boolean); //IsContext = False IsNew = False
					Interactable OperandVar679 = default(Interactable); //IsContext = False IsNew = False
					Interactable StoredVariable678 = ((Interactable)prop676.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
					if(StoredVariable678 != null)
					{
						OperandVar679 = StoredVariable678;
					}
					System.Boolean prop680 = External.Has( (OperandVar679)); //IsContext = False IsNew = False
					OperandVar681 = prop680;
					if(ifResult677 =  (OperandVar681))
					{
						OperandVar682 = ifResult677;
					}
				}
				
				System.Boolean OperandVar686 = default(System.Boolean); //IsContext = False IsNew = False
				SelectableMarker OperandVar684 = default(SelectableMarker); //IsContext = False IsNew = False
				SelectableMarker StoredVariable683 = ((SelectableMarker)StoredVariable674.GetComponent(typeof(SelectableMarker))); //IsContext = False IsNew = False
				if(StoredVariable683 != null)
				{
					OperandVar684 = StoredVariable683;
				}
				System.Boolean prop685 = External.Has( (OperandVar684)); //IsContext = False IsNew = False
				OperandVar686 = prop685;
				if(ifResult675 = ( ( (OperandVar682))) && ( (!(OperandVar686))))
				{
					applicable = true;
					OperandVar687 = applicable;
				}
			}
			return (System.Boolean) (OperandVar687);
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
			UnityEngine.GameObject OperandVar688 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar688 = root;
			UnityEngine.GameObject ctx =  (OperandVar688); //IsContext = False IsNew = False
			
			{
				BarsManager subContext689 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext689 ContextSwitchInterpreter
				if(subContext689 != null)
				{
					UnityEngine.GameObject OperandVar691 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop690 = subContext689.GetRightBar(); //IsContext = False IsNew = False
					if(prop690 != null)
					{
						OperandVar691 = prop690;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar691); //IsContext = False IsNew = False
					
					{
						//ContextStatement UnityEngine.GameObject p_ctx ContextSwitchInterpreter
						if(p_ctx != null)
						{
							System.Boolean OperandVar695 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar693 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable692 = ((UiObject)p_ctx.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable692 != null)
							{
								OperandVar693 = StoredVariable692;
							}
							System.Boolean prop694 = External.Has( (OperandVar693)); //IsContext = False IsNew = False
							OperandVar695 = prop694;
							if( (OperandVar695))
							{
								UnityEngine.GameObject OperandVar696 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar696 = p_ctx;
								ctx =  (OperandVar696);
							}
						}
					}
				}
			}
			
			{
				//ContextStatement UnityEngine.GameObject ctx ContextSwitchInterpreter
				if(ctx != null)
				{
					System.String OperandVar697 = default(System.String); //IsContext = False IsNew = False
					OperandVar697 = "interactions_ui";
					
					{
						UnityEngine.GameObject FuncCtx698 = External.SpawnPrefab(( (OperandVar697)).ToString());; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject FuncCtx698 ContextPropertySwitchInterpreter
						if(FuncCtx698 != null)
						{
							
							{
								InteractableUI subContext699 = (InteractableUI)FuncCtx698.GetComponent(typeof(InteractableUI)); //IsContext = True IsNew = False
								//ContextStatement InteractableUI subContext699 ContextSwitchInterpreter
								if(subContext699 != null)
								{
									Interactable OperandVar703 = default(Interactable); //IsContext = False IsNew = False
									UiObject StoredVariable700 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
									if(StoredVariable700 != null)
									{
										UnityEngine.GameObject prop701 = StoredVariable700.ShowedObject; //IsContext = False IsNew = False
										if(prop701 != null)
										{
											Interactable StoredVariable702 = ((Interactable)prop701.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
											if(StoredVariable702 != null)
											{
												OperandVar703 = StoredVariable702;
											}
										}
									}
									subContext699.TargetInteractable = (Interactable)( (OperandVar703));
								}
							}
							UnityEngine.GameObject OperandVar704 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar704 = FuncCtx698;
							UnityEngine.GameObject OperandVar705 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar705 = ctx;
							External.SetParent((UnityEngine.GameObject)( (OperandVar704)),(UnityEngine.GameObject)( (OperandVar705)));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip=("show this interactable object name to Debug console"), OnceInCategory=false)]
    public class interaction_log_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar708 = default(System.Boolean); //IsContext = False IsNew = False
			Interactable StoredVariable706 = ((Interactable)root.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
			if(StoredVariable706 != null)
			{
				Named StoredVariable707 = ((Named)StoredVariable706.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable707 != null)
				{
					applicable = true;
					OperandVar708 = applicable;
				}
			}
			return (System.Boolean) (OperandVar708);
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
			
			System.String OperandVar711 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable709 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable709 != null)
			{
				System.String prop710 = StoredVariable709.FullName; //IsContext = False IsNew = False
				if(prop710 != null)
				{
					OperandVar711 = prop710;
				}
			}
			External.Log((System.Object)( (OperandVar711)));
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
			
			System.Boolean OperandVar713 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable712 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable712 != null)
			{
				applicable = true;
				OperandVar713 = applicable;
			}
			return (System.Boolean) (OperandVar713);
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
			
			System.Boolean OperandVar722 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable714 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable714 != null)
			{
				Markers StoredVariable715 = ((Markers)StoredVariable714.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable715 != null)
				{
					System.Boolean ifResult716; //IsContext = False IsNew = False
					
					
					System.Int32 OperandVar718 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop717 = External.CurrentDate(); //IsContext = False IsNew = False
					OperandVar718 = prop717;
					
					
					
					System.Boolean OperandVar721 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar719 = default(System.String); //IsContext = False IsNew = False
					OperandVar719 = "lost";
					System.Boolean prop720 = StoredVariable715.HasMarker( (OperandVar719)); //IsContext = False IsNew = False
					OperandVar721 = prop720;
					if(ifResult716 = ( (( ( (OperandVar718))) > ( ( (0f))))) && ( (!(OperandVar721))))
					{
						applicable = true;
						OperandVar722 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar722);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Int32 OperandVar724 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop723 = External.Sanity; //IsContext = False IsNew = False
			OperandVar724 = prop723;
			
			
			if(( ( (OperandVar724))) == ( ( (0f))))
			{
				System.String OperandVar725 = default(System.String); //IsContext = False IsNew = False
				OperandVar725 = "you_in_the_cult_now";
				External.Lose(( (OperandVar725)).ToString());
				
				{
					Markers subContext726 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext726 ContextSwitchInterpreter
					if(subContext726 != null)
					{
						System.String OperandVar727 = default(System.String); //IsContext = False IsNew = False
						OperandVar727 = "lost";
						subContext726.SetMarker(( (OperandVar727)).ToString());
					}
				}
			}
			
			System.Int32 OperandVar729 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop728 = External.Influence; //IsContext = False IsNew = False
			OperandVar729 = prop728;
			
			
			if(( ( (OperandVar729))) == ( ( (0f))))
			{
				System.String OperandVar730 = default(System.String); //IsContext = False IsNew = False
				OperandVar730 = "they_fired_you";
				External.Lose(( (OperandVar730)).ToString());
				
				{
					Markers subContext731 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext731 ContextSwitchInterpreter
					if(subContext731 != null)
					{
						System.String OperandVar732 = default(System.String); //IsContext = False IsNew = False
						OperandVar732 = "lost";
						subContext731.SetMarker(( (OperandVar732)).ToString());
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
			
			System.Boolean OperandVar736 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable733 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable733 != null)
			{
				UnityEngine.GameObject prop734 = StoredVariable733.ShowedObject; //IsContext = False IsNew = False
				if(prop734 != null)
				{
					LostEvent StoredVariable735 = ((LostEvent)prop734.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
					if(StoredVariable735 != null)
					{
						applicable = true;
						OperandVar736 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar736);
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
				EncounterUi subContext737 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext737 ContextSwitchInterpreter
				if(subContext737 != null)
				{
					System.String OperandVar742 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable738 = ((EncounterUi)subContext737.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable738 != null)
					{
						UnityEngine.GameObject prop739 = StoredVariable738.ShowedObject; //IsContext = False IsNew = False
						if(prop739 != null)
						{
							LostEvent StoredVariable740 = ((LostEvent)prop739.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
							if(StoredVariable740 != null)
							{
								System.String prop741 = StoredVariable740.Why; //IsContext = False IsNew = False
								if(prop741 != null)
								{
									OperandVar742 = prop741;
								}
							}
						}
					}
					subContext737.Description = (System.String)( (OperandVar742));
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
			
			System.Boolean OperandVar746 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable743 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable743 != null)
			{
				UnityEngine.GameObject prop744 = StoredVariable743.ShowedObject; //IsContext = False IsNew = False
				if(prop744 != null)
				{
					WinEvent StoredVariable745 = ((WinEvent)prop744.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
					if(StoredVariable745 != null)
					{
						applicable = true;
						OperandVar746 = applicable;
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
				EncounterUi subContext747 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext747 ContextSwitchInterpreter
				if(subContext747 != null)
				{
					System.String OperandVar752 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable748 = ((EncounterUi)subContext747.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable748 != null)
					{
						UnityEngine.GameObject prop749 = StoredVariable748.ShowedObject; //IsContext = False IsNew = False
						if(prop749 != null)
						{
							WinEvent StoredVariable750 = ((WinEvent)prop749.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
							if(StoredVariable750 != null)
							{
								System.String prop751 = StoredVariable750.Why; //IsContext = False IsNew = False
								if(prop751 != null)
								{
									OperandVar752 = prop751;
								}
							}
						}
					}
					subContext747.Description = (System.String)( (OperandVar752));
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
			
			System.Boolean OperandVar756 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable753 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable753 != null)
			{
				UnityEngine.GameObject prop754 = StoredVariable753.ShowedObject; //IsContext = False IsNew = False
				if(prop754 != null)
				{
					NotifyEvent StoredVariable755 = ((NotifyEvent)prop754.GetComponent(typeof(NotifyEvent))); //IsContext = False IsNew = False
					if(StoredVariable755 != null)
					{
						applicable = true;
						OperandVar756 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar756);
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
				EncounterUi subContext757 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext757 ContextSwitchInterpreter
				if(subContext757 != null)
				{
					System.String OperandVar762 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable758 = ((EncounterUi)subContext757.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable758 != null)
					{
						UnityEngine.GameObject prop759 = StoredVariable758.ShowedObject; //IsContext = False IsNew = False
						if(prop759 != null)
						{
							NotifyEvent StoredVariable760 = ((NotifyEvent)prop759.GetComponent(typeof(NotifyEvent))); //IsContext = False IsNew = False
							if(StoredVariable760 != null)
							{
								System.String prop761 = StoredVariable760.OfWhat; //IsContext = False IsNew = False
								if(prop761 != null)
								{
									OperandVar762 = prop761;
								}
							}
						}
					}
					subContext757.Description = (System.String)( (OperandVar762));
				}
			}
		}
        }
    }
}
