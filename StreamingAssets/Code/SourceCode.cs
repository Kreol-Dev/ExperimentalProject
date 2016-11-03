namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="conflict_decomposition", OncePerObject=false)]
    public class war_conflict : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar6 = default(System.Boolean); //IsContext = False IsNew = False
			Conflict StoredVariable0 = ((Conflict)root.GetComponent(typeof(Conflict))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				Markers StoredVariable1 = ((Markers)StoredVariable0.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable1 != null)
				{
					System.Boolean ifResult2; //IsContext = False IsNew = False
					System.Boolean OperandVar5 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar3 = default(System.String); //IsContext = False IsNew = False
					OperandVar3 = "conflict_decomposed";
					System.Boolean prop4 = StoredVariable1.HasMarker( (OperandVar3)); //IsContext = False IsNew = False
					OperandVar5 = prop4;
					if(ifResult2 = !(OperandVar5))
					{
						applicable = true;
						OperandVar6 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar6);
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
				Markers subContext7 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext7 ContextSwitchInterpreter
				if(subContext7 != null)
				{
					System.String OperandVar8 = default(System.String); //IsContext = False IsNew = False
					OperandVar8 = "conflict_decomposed";
					subContext7.SetMarker(( (OperandVar8)).ToString());
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar13 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable9 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable9 != null)
			{
				System.Boolean ifResult10; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar12 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop11 = StoredVariable9.Places; //IsContext = False IsNew = False
				if(prop11 != null)
				{
					OperandVar12 = prop11;
				}
				
				
				if(ifResult10 = ( ( (OperandVar12 != null ? OperandVar12.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar13 = applicable;
				}
			}
			return (System.Boolean) (OperandVar13);
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
				Space subContext14 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext14 ContextSwitchInterpreter
				if(subContext14 != null)
				{
					
					subContext14.Size = (System.Int32)( (5f));
					System.Single OperandVar16 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop15 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar16 = prop15;
					for (int i = 0; i <  (OperandVar16); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc17 = loc; //IsContext = True IsNew = False
							Entity AddContext18 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext18 ContextSwitchInterpreter
								if(AddContext18 != null)
								{
									UnityEngine.Vector3 OperandVar28 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar22 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar20 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop19 = External.MapX(); //IsContext = False IsNew = False
									OperandVar20 = prop19;
									System.Single prop21 = External.Random( (0f), (OperandVar20)); //IsContext = False IsNew = False
									OperandVar22 = prop21;
									System.Single OperandVar26 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar24 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop23 = External.MapX(); //IsContext = False IsNew = False
									OperandVar24 = prop23;
									System.Single prop25 = External.Random( (0f), (OperandVar24)); //IsContext = False IsNew = False
									OperandVar26 = prop25;
									UnityEngine.Vector3 prop27 = External.Vec( (OperandVar22), (OperandVar26)); //IsContext = False IsNew = False
									OperandVar28 = prop27;
									AddContext18.Position = (UnityEngine.Vector3)( (OperandVar28));
								}
							}
							Place AddContext29 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext29 ContextSwitchInterpreter
								if(AddContext29 != null)
								{
									System.Single OperandVar31 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop30 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar31 = prop30;
									AddContext29.Size = (System.Int32)( (OperandVar31));
								}
							}
							Markers AddContext32 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext32 ContextSwitchInterpreter
								if(AddContext32 != null)
								{
									System.String OperandVar33 = default(System.String); //IsContext = False IsNew = False
									OperandVar33 = "history_place";
									AddContext32.SetMarker(( (OperandVar33)).ToString());
								}
							}
							Named AddContext34 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext34 ContextSwitchInterpreter
								if(AddContext34 != null)
								{
									
									
									
									AddContext34.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar37 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar35 = default(System.String); //IsContext = False IsNew = False
									OperandVar35 = "human_name";
									System.String prop36 = External.RandomName( (OperandVar35)); //IsContext = False IsNew = False
									if(prop36 != null)
									{
										OperandVar37 = prop36;
									}
									AddContext34.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar37)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar39 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable38 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable38 != null)
						{
							OperandVar39 = StoredVariable38;
						}
						subContext14.Attach((Place)( (OperandVar39)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar53 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable40 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable40 != null)
			{
				Markers StoredVariable41 = ((Markers)StoredVariable40.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable41 != null)
				{
					System.Boolean ifResult42; //IsContext = False IsNew = False
					
					System.Boolean OperandVar49 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable40 != null)
					{
						UnityEngine.GameObject prop43 = StoredVariable40.ShowedObject; //IsContext = False IsNew = False
						if(prop43 != null)
						{
							System.Boolean ifResult44; //IsContext = False IsNew = False
							System.Boolean OperandVar48 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar46 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable45 = ((Named)prop43.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable45 != null)
							{
								OperandVar46 = StoredVariable45;
							}
							System.Boolean prop47 = External.Has( (OperandVar46)); //IsContext = False IsNew = False
							OperandVar48 = prop47;
							if(ifResult44 =  (OperandVar48))
							{
								OperandVar49 = ifResult44;
							}
						}
					}
					
					System.Boolean OperandVar52 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar50 = default(System.String); //IsContext = False IsNew = False
					OperandVar50 = "named_ui_marker";
					System.Boolean prop51 = StoredVariable41.HasMarker( (OperandVar50)); //IsContext = False IsNew = False
					OperandVar52 = prop51;
					if(ifResult42 = ( ( (OperandVar49))) && ( (!(OperandVar52))))
					{
						applicable = true;
						OperandVar53 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar53);
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
				Markers subContext54 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext54 ContextSwitchInterpreter
				if(subContext54 != null)
				{
					System.String OperandVar55 = default(System.String); //IsContext = False IsNew = False
					OperandVar55 = "named_ui_marker";
					subContext54.SetUiMarker(( (OperandVar55)).ToString());
				}
			}
			
			{
				UiObject subContext56 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext56 ContextSwitchInterpreter
				if(subContext56 != null)
				{
					Named OperandVar59 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop57 = subContext56.ShowedObject; //IsContext = False IsNew = False
					if(prop57 != null)
					{
						Named StoredVariable58 = ((Named)prop57.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable58 != null)
						{
							OperandVar59 = StoredVariable58;
						}
					}
					Named showed_named =  (OperandVar59); //IsContext = False IsNew = False
					TextField ContextVar60 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar60 ContextSwitchInterpreter
						if(ContextVar60 != null)
						{
							System.String OperandVar62 = default(System.String); //IsContext = False IsNew = False
							System.String prop61 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop61 != null)
							{
								OperandVar62 = prop61;
							}
							ContextVar60.Show(( (OperandVar62)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda63 = () => 
									{
										System.String OperandVar65 = default(System.String); //IsContext = False IsNew = False
										System.String prop64 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop64 != null)
										{
											OperandVar65 = prop64;
										}
										ContextVar60.Show(( (OperandVar65)).ToString());
									};
									showed_named.OnUpdate(Lambda63);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext66 = ContextVar60.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext66 ContextPropertySwitchInterpreter
								if(subContext66 != null)
								{
									
									subContext66.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar67 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar67 != null) EntVar67.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar76 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable68 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable68 != null)
			{
				Place StoredVariable69 = ((Place)StoredVariable68.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable69 != null)
				{
					System.Boolean ifResult70; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar72 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop71 = StoredVariable69.Agents; //IsContext = False IsNew = False
					if(prop71 != null)
					{
						OperandVar72 = prop71;
					}
					
					
					
					System.Boolean OperandVar75 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar73 = default(System.String); //IsContext = False IsNew = False
					OperandVar73 = "agents_pool";
					System.Boolean prop74 = StoredVariable68.HasMarker( (OperandVar73)); //IsContext = False IsNew = False
					OperandVar75 = prop74;
					if(ifResult70 = ( (( ( (OperandVar72 != null ? OperandVar72.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar75))))
					{
						applicable = true;
						OperandVar76 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar76);
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
				Place subContext77 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext77 ContextSwitchInterpreter
				if(subContext77 != null)
				{
					
					subContext77.Size = (System.Int32)( (5f));
					System.Single OperandVar79 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop78 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar79 = prop78;
					for (int i = 0; i <  (OperandVar79); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag80 = ag; //IsContext = True IsNew = False
							Entity AddContext81 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext82 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext83 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext83 ContextSwitchInterpreter
								if(AddContext83 != null)
								{
									System.Single OperandVar85 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop84 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar85 = prop84;
									AddContext83.Age = (System.Int32)( (OperandVar85));
								}
							}
							Named AddContext86 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext86 ContextSwitchInterpreter
								if(AddContext86 != null)
								{
									
									
									
									AddContext86.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar89 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar87 = default(System.String); //IsContext = False IsNew = False
									OperandVar87 = "human_name";
									System.String prop88 = External.RandomName( (OperandVar87)); //IsContext = False IsNew = False
									if(prop88 != null)
									{
										OperandVar89 = prop88;
									}
									AddContext86.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar89)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar91 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable90 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable90 != null)
						{
							OperandVar91 = StoredVariable90;
						}
						subContext77.Attach((Agent)( (OperandVar91)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar98 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable92 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable92 != null)
			{
				System.Boolean ifResult93; //IsContext = False IsNew = False
				System.Boolean OperandVar97 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar95 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable94 = ((Blackboards.event_marker)StoredVariable92.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable94 != null)
				{
					OperandVar95 = StoredVariable94;
				}
				System.Boolean prop96 = External.Has( (OperandVar95)); //IsContext = False IsNew = False
				OperandVar97 = prop96;
				if(ifResult93 = !(OperandVar97))
				{
					applicable = true;
					OperandVar98 = applicable;
				}
			}
			return (System.Boolean) (OperandVar98);
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
			Entity EntVar99 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar99 != null) EntVar99.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar106 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable100 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable100 != null)
			{
				System.Boolean ifResult101; //IsContext = False IsNew = False
				System.Boolean OperandVar105 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar103 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable102 = ((Blackboards.personality)StoredVariable100.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable102 != null)
				{
					OperandVar103 = StoredVariable102;
				}
				System.Boolean prop104 = External.Has( (OperandVar103)); //IsContext = False IsNew = False
				OperandVar105 = prop104;
				if(ifResult101 = !(OperandVar105))
				{
					applicable = true;
					OperandVar106 = applicable;
				}
			}
			return (System.Boolean) (OperandVar106);
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
			Entity EntVar107 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar107 != null) EntVar107.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar114 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable108 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable108 != null)
			{
				System.Boolean ifResult109; //IsContext = False IsNew = False
				System.Boolean OperandVar113 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar111 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable110 = ((Blackboards.aged_generation)StoredVariable108.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable110 != null)
				{
					OperandVar111 = StoredVariable110;
				}
				System.Boolean prop112 = External.Has( (OperandVar111)); //IsContext = False IsNew = False
				OperandVar113 = prop112;
				if(ifResult109 = !(OperandVar113))
				{
					applicable = true;
					OperandVar114 = applicable;
				}
			}
			return (System.Boolean) (OperandVar114);
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
			Entity EntVar115 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar115 != null) EntVar115.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar125 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable116 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable116 != null)
			{
				Lore StoredVariable117 = ((Lore)StoredVariable116.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable117 != null)
				{
					Place StoredVariable118 = ((Place)StoredVariable117.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable118 != null)
					{
						System.Boolean ifResult119; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar121 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop120 = StoredVariable118.Agents; //IsContext = False IsNew = False
						if(prop120 != null)
						{
							OperandVar121 = prop120;
						}
						
						
						
						System.Boolean OperandVar124 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar122 = default(System.String); //IsContext = False IsNew = False
						OperandVar122 = "lore_pool";
						System.Boolean prop123 = StoredVariable116.HasMarker( (OperandVar122)); //IsContext = False IsNew = False
						OperandVar124 = prop123;
						if(ifResult119 = ( (( ( (OperandVar121 != null ? OperandVar121.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar124))))
						{
							applicable = true;
							OperandVar125 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar125);
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
				Place subContext126 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext126 ContextSwitchInterpreter
				if(subContext126 != null)
				{
					
					subContext126.Size = (System.Int32)( (10f));
					System.Single OperandVar128 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop127 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar128 = prop127;
					for (int i = 0; i <  (OperandVar128); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag129 = old_ag; //IsContext = True IsNew = False
							Entity AddContext130 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext131 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext132 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext133 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext133 ContextSwitchInterpreter
								if(AddContext133 != null)
								{
									System.Single OperandVar135 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop134 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar135 = prop134;
									AddContext133.Age = (System.Int32)( (OperandVar135));
								}
							}
							Named AddContext136 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext136 ContextSwitchInterpreter
								if(AddContext136 != null)
								{
									
									
									
									AddContext136.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar139 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar137 = default(System.String); //IsContext = False IsNew = False
									OperandVar137 = "human_name";
									System.String prop138 = External.RandomName( (OperandVar137)); //IsContext = False IsNew = False
									if(prop138 != null)
									{
										OperandVar139 = prop138;
									}
									AddContext136.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar139)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar141 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable140 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable140 != null)
						{
							OperandVar141 = StoredVariable140;
						}
						subContext126.Attach((Agent)( (OperandVar141)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar147 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable142 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable142 != null)
			{
				Named StoredVariable143 = ((Named)StoredVariable142.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable143 != null)
				{
					System.Boolean ifResult144; //IsContext = False IsNew = False
					
					System.Boolean OperandVar146 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable142 != null)
					{
						System.Boolean prop145 = StoredVariable142.Act; //IsContext = False IsNew = False
						OperandVar146 = prop145;
					}
					
					
					if(ifResult144 = ( ( (OperandVar146))) == ( ( (true))))
					{
						applicable = true;
						OperandVar147 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar147);
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
			
			System.String OperandVar151 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable148 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable148 != null)
			{
				System.String OperandVar149 = default(System.String); //IsContext = False IsNew = False
				OperandVar149 = "main_name";
				System.String prop150 = StoredVariable148.Get( (OperandVar149)); //IsContext = False IsNew = False
				if(prop150 != null)
				{
					OperandVar151 = prop150;
				}
			}
			External.Log((System.Object)( (OperandVar151)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar159 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable152 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable152 != null)
			{
				Agent StoredVariable153 = ((Agent)StoredVariable152.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable153 != null)
				{
					System.Boolean ifResult154; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar156 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop155 = StoredVariable153.Act; //IsContext = False IsNew = False
					OperandVar156 = prop155;
					
					
					
					System.Boolean OperandVar158 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable152 != null)
					{
						System.Boolean prop157 = StoredVariable152.Dead; //IsContext = False IsNew = False
						OperandVar158 = prop157;
					}
					if(ifResult154 = ( (( ( (OperandVar156))) == ( ( (true))))) && ( (!(OperandVar158))))
					{
						applicable = true;
						OperandVar159 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar159);
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
			
			
			
			
			UnityEngine.GameObject OperandVar160 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar160 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar160)))));
			UnityEngine.GameObject OperandVar161 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar161 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar161)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar171 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable162 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable162 != null)
			{
				Markers StoredVariable163 = ((Markers)StoredVariable162.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable163 != null)
				{
					System.Boolean ifResult164; //IsContext = False IsNew = False
					
					System.Boolean OperandVar167 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar165 = default(System.String); //IsContext = False IsNew = False
					OperandVar165 = "map_anchored";
					System.Boolean prop166 = StoredVariable163.HasMarker( (OperandVar165)); //IsContext = False IsNew = False
					OperandVar167 = prop166;
					
					System.Boolean OperandVar170 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar168 = default(System.String); //IsContext = False IsNew = False
					OperandVar168 = "history_place";
					System.Boolean prop169 = StoredVariable163.HasMarker( (OperandVar168)); //IsContext = False IsNew = False
					OperandVar170 = prop169;
					if(ifResult164 = ( (!(OperandVar167))) && ( ( (OperandVar170))))
					{
						applicable = true;
						OperandVar171 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar171);
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
				Markers subContext172 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext172 ContextSwitchInterpreter
				if(subContext172 != null)
				{
					System.String OperandVar173 = default(System.String); //IsContext = False IsNew = False
					OperandVar173 = "map_anchored";
					subContext172.SetUiMarker(( (OperandVar173)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar174 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar174 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar174)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar181 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable175 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable175 != null)
			{
				Markers StoredVariable176 = ((Markers)StoredVariable175.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable176 != null)
				{
					System.Boolean ifResult177; //IsContext = False IsNew = False
					System.Boolean OperandVar180 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar178 = default(System.String); //IsContext = False IsNew = False
					OperandVar178 = "encounter_ui_enlist";
					System.Boolean prop179 = StoredVariable176.HasMarker( (OperandVar178)); //IsContext = False IsNew = False
					OperandVar180 = prop179;
					if(ifResult177 = !(OperandVar180))
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
				Markers subContext182 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext182 ContextSwitchInterpreter
				if(subContext182 != null)
				{
					System.String OperandVar183 = default(System.String); //IsContext = False IsNew = False
					OperandVar183 = "encounter_ui_enlist";
					subContext182.SetUiMarker(( (OperandVar183)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar184 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar184 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar184)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable185 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable185 != null)
			{
				Named StoredVariable186 = ((Named)StoredVariable185.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable186 != null)
				{
					System.Boolean ifResult187; //IsContext = False IsNew = False
					
					System.Boolean OperandVar189 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable185 != null)
					{
						System.Boolean prop188 = StoredVariable185.Act; //IsContext = False IsNew = False
						OperandVar189 = prop188;
					}
					
					
					if(ifResult187 = ( ( (OperandVar189))) == ( ( (true))))
					{
						applicable = true;
						OperandVar190 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar190);
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
				UnityEngine.GameObject enc191 = enc; //IsContext = True IsNew = False
				Encounter AddContext192 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext192 ContextSwitchInterpreter
					if(AddContext192 != null)
					{
						UnityEngine.GameObject OperandVar193 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar193 = root;
						AddContext192.Context = (UnityEngine.GameObject)( (OperandVar193));
					}
				}
				Markers AddContext194 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext195 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext196 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext196 ContextSwitchInterpreter
					if(AddContext196 != null)
					{
						System.String OperandVar197 = default(System.String); //IsContext = False IsNew = False
						OperandVar197 = "main_name";
						
						
						AddContext196.Set(( (OperandVar197)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false)]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar211 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable198 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable198 != null)
			{
				Markers StoredVariable199 = ((Markers)StoredVariable198.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable199 != null)
				{
					System.Boolean ifResult200; //IsContext = False IsNew = False
					
					System.Boolean OperandVar207 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable198 != null)
					{
						UnityEngine.GameObject prop201 = StoredVariable198.ShowedObject; //IsContext = False IsNew = False
						if(prop201 != null)
						{
							System.Boolean ifResult202; //IsContext = False IsNew = False
							System.Boolean OperandVar206 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar204 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable203 = ((Place)prop201.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable203 != null)
							{
								OperandVar204 = StoredVariable203;
							}
							System.Boolean prop205 = External.Has( (OperandVar204)); //IsContext = False IsNew = False
							OperandVar206 = prop205;
							if(ifResult202 =  (OperandVar206))
							{
								OperandVar207 = ifResult202;
							}
						}
					}
					
					System.Boolean OperandVar210 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar208 = default(System.String); //IsContext = False IsNew = False
					OperandVar208 = "place_ui_cards_list";
					System.Boolean prop209 = StoredVariable199.HasMarker( (OperandVar208)); //IsContext = False IsNew = False
					OperandVar210 = prop209;
					if(ifResult200 = ( ( (OperandVar207))) && ( (!(OperandVar210))))
					{
						applicable = true;
						OperandVar211 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar211);
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
				Markers subContext212 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext212 ContextSwitchInterpreter
				if(subContext212 != null)
				{
					System.String OperandVar213 = default(System.String); //IsContext = False IsNew = False
					OperandVar213 = "place_ui_cards_list";
					subContext212.SetUiMarker(( (OperandVar213)).ToString());
				}
			}
			Place OperandVar217 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable214 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable214 != null)
			{
				UnityEngine.GameObject prop215 = StoredVariable214.ShowedObject; //IsContext = False IsNew = False
				if(prop215 != null)
				{
					Place StoredVariable216 = ((Place)prop215.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable216 != null)
					{
						OperandVar217 = StoredVariable216;
					}
				}
			}
			Place pl =  (OperandVar217); //IsContext = False IsNew = False
			System.String OperandVar218 = default(System.String); //IsContext = False IsNew = False
			OperandVar218 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx219 = External.SpawnPrefab(( (OperandVar218)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx219 ContextPropertySwitchInterpreter
				if(FuncCtx219 != null)
				{
					
					{
						AgentsUI subContext220 = (AgentsUI)FuncCtx219.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext220 ContextSwitchInterpreter
						if(subContext220 != null)
						{
							Place OperandVar221 = default(Place); //IsContext = False IsNew = False
							OperandVar221 = pl;
							subContext220.TargetPlace = (Place)( (OperandVar221));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext222 = (CardsHolderAgentsAdapter)FuncCtx219.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext222 ContextSwitchInterpreter
						if(subContext222 != null)
						{
							Place OperandVar223 = default(Place); //IsContext = False IsNew = False
							OperandVar223 = pl;
							subContext222.TargetPlace = (Place)( (OperandVar223));
						}
					}
					UnityEngine.GameObject OperandVar224 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar224 = FuncCtx219;
					UnityEngine.GameObject OperandVar225 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar225 = root;
					External.SetParent((UnityEngine.GameObject)( (OperandVar224)),(UnityEngine.GameObject)( (OperandVar225)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true)]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar236 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable226 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable226 != null)
			{
				Markers StoredVariable227 = ((Markers)StoredVariable226.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable227 != null)
				{
					System.Boolean ifResult228; //IsContext = False IsNew = False
					System.Boolean OperandVar235 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable226 != null)
					{
						UnityEngine.GameObject prop229 = StoredVariable226.ShowedObject; //IsContext = False IsNew = False
						if(prop229 != null)
						{
							System.Boolean ifResult230; //IsContext = False IsNew = False
							System.Boolean OperandVar234 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar232 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable231 = ((Place)prop229.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable231 != null)
							{
								OperandVar232 = StoredVariable231;
							}
							System.Boolean prop233 = External.Has( (OperandVar232)); //IsContext = False IsNew = False
							OperandVar234 = prop233;
							if(ifResult230 =  (OperandVar234))
							{
								OperandVar235 = ifResult230;
							}
						}
					}
					if(ifResult228 =  (OperandVar235))
					{
						applicable = true;
						OperandVar236 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar236);
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
			
			TextField ContextVar237 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement TextField ContextVar237 ContextSwitchInterpreter
				if(ContextVar237 != null)
				{
					
					ContextVar237.Label = (System.String)( ("size"));
					System.Int32 OperandVar242 = default(System.Int32); //IsContext = False IsNew = False
					UiObject StoredVariable238 = ((UiObject)ContextVar237.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
					if(StoredVariable238 != null)
					{
						UnityEngine.GameObject prop239 = StoredVariable238.ShowedObject; //IsContext = False IsNew = False
						if(prop239 != null)
						{
							Place StoredVariable240 = ((Place)prop239.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable240 != null)
							{
								System.Int32 prop241 = StoredVariable240.Size; //IsContext = False IsNew = False
								OperandVar242 = prop241;
							}
						}
					}
					ContextVar237.Show(( (OperandVar242)).ToString());
					
					{
						UnityEngine.UI.LayoutElement subContext243 = ContextVar237.Layout; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.UI.LayoutElement subContext243 ContextPropertySwitchInterpreter
						if(subContext243 != null)
						{
							
							subContext243.minHeight = (System.Single)( (20f));
						}
					}
				}
			}
			Entity EntVar244 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar244 != null) EntVar244.ComponentAdded();
		}
        }
    }
}
